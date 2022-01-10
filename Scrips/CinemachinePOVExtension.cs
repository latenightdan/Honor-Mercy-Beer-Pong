using UnityEngine;
using Cinemachine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class CinemachinePOVExtension : CinemachineExtension
{
   

    

    private firstPersonInputSystem inputManager;

    [Header("Player Controls")]
    [SerializeField]
    public float horizontalSpeed = 1000f;
    [SerializeField]
    public float verticalSpeed = 1000f;
    [SerializeField]
    private float clampAngle = 80f;

    private Vector3 startingRotation;

    public CinemachineVirtualCamera playerCamera;

    [Header("Honor Mercy Camera Controls")]

    public float zoom = 20;

    public float smooth = 5;

    public float smoothLookAtYOffset = -.1f;

    [SerializeField] Transform lookAtEnemy;

    //REMEMBER TO MAKE THIS FALSE TO START CHOICE STATE
    [Header("state controller")]
    public bool canMove = true;

    [Header("Weapon Controls")]


    public ParticleSystem muzzleFlash;

    [SerializeField] GameObject hitEffect;


    [SerializeField] float damage = 1f;

    [SerializeField] float range = 100f;



    public int narcsPerHit = 1;
    narcPoints narcpoints;

    public AudioClip impact;
    AudioSource audioSource;

    public bool honorMercyStateBool = false;




    //[SerializeField] GameObject gun; todo make more weapons for greater executions

    LauncherFPS controls;



    //think about taking out private on this. THAT mIGHT BW WHY it won't recieve other methods


    void Awake()
    {


        if (startingRotation == null) startingRotation = transform.localRotation.eulerAngles;
        inputManager = firstPersonInputSystem.Instance;



    }

    void Start()
    {

        audioSource = GetComponent<AudioSource>();
        narcpoints = FindObjectOfType<narcPoints>();

    }


    // Update is called once per frame
    void Update()
    {


        if (canMove)
        {
            cameraMovement();



        }


        if (honorMercyStateBool)
        {
            honorMercyState();

        }



    }
    void honorMercyState()
    {
        superComplicatedLookAt();
        smoothZoomIn();
        honorMercyChoice();
        this.GetComponent<LauncherFPS>().end();
        this.GetComponent<LauncherFPS>().enabled = false;
    }

    public void smoothZoomIn()
    {
        playerCamera.m_Lens.FieldOfView = Mathf.Lerp(playerCamera.m_Lens.FieldOfView, zoom, Time.deltaTime * zoom);
    }

    public void superComplicatedLookAt()
    {
        Vector3 targetDir = lookAtEnemy.transform.position - playerCamera.transform.position;
        targetDir.y = smoothLookAtYOffset;
        float step = smooth * Time.deltaTime;
        Vector3 newDir = Vector3.RotateTowards(playerCamera.transform.forward, targetDir, step, 0.0f);
        playerCamera.transform.rotation = Quaternion.LookRotation(newDir);
    }

    public void end()
    {
        canMove = false;
    }
    public void unEnd()
    {
        canMove = true;
    }
    public void finishHim()
    {
        canMove = false;
        honorMercyStateBool = true;
    }
    public void UIStuff()
    {
        GetComponent<QTEvent>().honorMercyHandler();
        GetComponent<Animator>().SetTrigger("honor");

    }
    private void cameraMovement()
    {
        Vector2 deltaInput = inputManager.GetStick();
        startingRotation.x += deltaInput.x * verticalSpeed * Time.deltaTime;
        startingRotation.y += -deltaInput.y * horizontalSpeed * Time.deltaTime;
        startingRotation.y = Mathf.Clamp(startingRotation.y, -clampAngle, clampAngle);
        playerCamera.transform.localRotation = Quaternion.Euler(startingRotation.y, startingRotation.x + 180f, 0f);

    }
    void honorMercyChoice()
    {


        if (inputManager.Honor())
        {

            Shoot();
            reload();
            audioSource.PlayOneShot(impact, 0.7F);

            narcpoints.narcHit(narcsPerHit);
            honorMercyStateBool = false;

            //give throw up upgrade
            //todo set up limit for upgrade. start with x, and begin with more after winning

        }
        if (inputManager.Mercy())
        {
            drunkControl drunkcontrol = FindObjectOfType<drunkControl>();
            drunkcontrol.increaseTolerance();
            reload();
            honorMercyStateBool = false;
            //end();
            //reload();
            //increase resistance todo find a way to start the game with more resistance after a win
            //todo other upgrades like not having to drink after ball sink, or slow motion

        }
    }



    void honortrigger()
    {
        GetComponent<Animator>().SetTrigger("honor");
    }
    public void Shoot()
    {

        PlayMuzzleFlash();
        ProcessRayCast();


    }

    private void ProcessRayCast()
    {
        RaycastHit hit;
        if (Physics.Raycast(playerCamera.transform.position, playerCamera.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
            CreateHitImpact(hit);
            triggers target = hit.transform.GetComponent<triggers>();
            if (target == null) return;
            target.TakeDamage(damage);
        }
    }
    public void die()
    {
        GetComponent<Animator>().SetTrigger("die");
    }
    private void CreateHitImpact(RaycastHit hit)
    {
        GameObject impact = Instantiate(hitEffect, hit.point, Quaternion.LookRotation(hit.normal));
        Destroy(impact, 1f);
    }

    public void PlayMuzzleFlash()
    {
        muzzleFlash.Play();
        print("commmeeonnnn");
    }







    //STUPID: SCENE MANAGEMENT ON THIS SCRIPT, BUT IT WON'T FUCKING CALL OTHER SCRIPT FOR SOME REASON
    //TODO: MOVE THIS TO ANOTHER SCRIPT

    public void ReloadGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void quitgame()
    {
        Application.Quit();

    }

    public void reload()
    {
        StartCoroutine(reloadgame());

        IEnumerator reloadgame()
        {
            yield return new WaitForSeconds(4);

            ReloadGame();
        }



    }


    protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
    {
        if (vcam.Follow)
        {
            if (stage == CinemachineCore.Stage.Aim)
            {
                
                Vector2 deltaInput = inputManager.GetStick();
                startingRotation.x += deltaInput.x * verticalSpeed * Time.deltaTime;
                startingRotation.y += deltaInput.y * horizontalSpeed * Time.deltaTime;
                startingRotation.y = Mathf.Clamp(startingRotation.y, -clampAngle, clampAngle);
                state.RawOrientation = Quaternion.Euler(-startingRotation.y, startingRotation.x, 0f);
            }
        }

    }

}



