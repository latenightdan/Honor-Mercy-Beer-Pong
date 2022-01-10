using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class CameraNotCineMaBitch : MonoBehaviour
{
    [Header("Player Controls")]
    [SerializeField]
    private float horizontalSpeed = 10f;
    [SerializeField]
    private float verticalSpeed = 10f;
    [SerializeField]
    private float clampAngle = 80f;

    private Vector3 startingRotation;

    public Camera playerCamera;

    [Header("Honor Mercy Camera Controls")]

    public int zoom = 20;

    public float smooth = 5;

    [SerializeField] Transform lookAtEnemy;

    //REMEMBER TO MAKE THIS FALSE TO START CHOICE STATE
    [Header("state controller")]
    public bool canMove = true;

    [Header("Weapon Controls")]
   

    public ParticleSystem muzzleFlash;

    [SerializeField] GameObject hitEffect;


    [SerializeField] float damage = 1f;

    [SerializeField] float range = 100f;

    SceneLoader puss;

    //[SerializeField] GameObject gun; todo make more weapons for greater executions

    LauncherFPS controls;

    
   


    firstPersonInputSystem inputManager;
    //think about taking out private on this. THAT mIGHT BW WHY it won't recieve other methods


     void Awake()
    {

        
        if (startingRotation == null) startingRotation = transform.localRotation.eulerAngles;
        inputManager = firstPersonInputSystem.Instance;
        
        
    }
     void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        
        if (canMove)
        {
            cameraMovement();
            honorMercyChoice();

        }
        else 
        {

            //super Complicated lookat 
            Vector3 targetDir = lookAtEnemy.transform.position - playerCamera.transform.position;
            targetDir.y = 0;
            float step = smooth * Time.deltaTime;

            Vector3 newDir = Vector3.RotateTowards(playerCamera.transform.forward, targetDir, step, 0.0f);
            playerCamera.transform.rotation = Quaternion.LookRotation(newDir) ;

            //playerCamera.transform.forward = lookAtEnemy.transform.position;


            playerCamera.fieldOfView = Mathf.Lerp(playerCamera.fieldOfView, zoom, Time.deltaTime * zoom);

            //playerCamera.transform.LookAt(lookAtEnemy);
            
            honorMercyChoice();
            GetComponent<QTEvent>().honorMercyHandler();
            GetComponent<Animator>().SetTrigger("honor");
            this.GetComponent<LauncherFPS>().end();
            this.GetComponent<LauncherFPS>().enabled = false;
            
            
           

        }
   
    }

    public void end()
    {
        canMove = false; 
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

            

            
        }
        if (inputManager.Mercy())
        {
            canMove = false;
            
            //end();
            //reload();


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

    private  void CreateHitImpact(RaycastHit hit)
    {
       GameObject impact = Instantiate(hitEffect, hit.point, Quaternion.LookRotation(hit.normal));
        Destroy(impact, 1f);
    }

    public void PlayMuzzleFlash()
    {
        muzzleFlash.Play();
        print("commmeeonnnn");
    }







    //SUPER SKETCHY: SCENE MANAGEMENT ON THIS SCRIPT, BUT IT WON'T FUCKING CALL OTHER SCRIPT FOR SOME REASON
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
        StartCoroutine(jimmy());

        IEnumerator jimmy()
        {
            yield return new WaitForSeconds(4);

            ReloadGame();
        }



    }

}

//playerCamera.transform.forward = Vector3.Lerp(playerCamera.transform.position, lookAtEnemy.position, Time.deltaTime * zoom);
