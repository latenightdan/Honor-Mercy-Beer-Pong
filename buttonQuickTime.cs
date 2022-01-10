using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class buttonQuickTime : MonoBehaviour
{

    public float fillamnt = 0;

    public float timeThreshold = 0;

    [SerializeField] Canvas quickTimeCanvas;

    private firstPersonInputSystem inputManager;
    public bool drinky = false;
    public bool freeze;
    

    CameraNotCineMaBitch cameranotcinemabitch;

    GameObject player;
    public GameObject drinkFlash;
    BallHitCup ballhitcup;
    public GameObject flash;
    public float flashtime =.9f;
    void Awake()
    {



        inputManager = firstPersonInputSystem.Instance;


    }
    // Start is called before the first frame update
    void Start()
    {
       
        quickTimeCanvas.enabled = false;
        player = GameObject.FindWithTag("player");
        drinkFlash.SetActive(false);
        flash.SetActive(false);
        cameranotcinemabitch = FindObjectOfType<CameraNotCineMaBitch>();
    }

    // Update is called once per frame
    void Update()
    {

        if (drinky)
        { ButtonFill();
            
        }
        else
        {
            freeze = true;
            
        }

    }

    public void ButtonFill()
    {
        
        freeze = false;
        quickTimeCanvas.enabled = true;
        if (inputManager.PlayerJump())
        {
            fillamnt += .2f;
            bigTit();
            bigTit2();
        }

        timeThreshold += Time.deltaTime;
        if (timeThreshold > .1 && !freeze) //reduces time
        {
            timeThreshold = 0;
            fillamnt -= .02f;


        }
        if (fillamnt < 0) //keeps it at 0. can't go below
        {
            fillamnt = 0;
        }
        if (fillamnt > 1) //win
        {
            win();
        }
      
      
        GetComponent<Image>().fillAmount = fillamnt;
    }





    public void setDrinky()
    {
        drinky = true;
    }

    public void wtfFreeze()
    {
        if (freeze)
        {
            fillamnt = 0;
        }
    }
    void bigTit()

    {
        StartCoroutine(press());

        IEnumerator press()
        {
                drinkFlash.SetActive(true);
                yield return new WaitForSeconds(.09f);
                drinkFlash.SetActive(false);
        }
    }
    public void bigTit2()
    {
        StartCoroutine(tit());

        IEnumerator tit()
        {
            flash.SetActive(true);
            yield return new WaitForSeconds(flashtime);
            flash.SetActive(false);
        }
    }
    public void resetDrink()
    {

        fillamnt = 0.1f;


    }
    public void win()
    {
        
            player.GetComponent<Animator>().SetTrigger("drink2");

            quickTimeCanvas.enabled = false;
            drinky = false;
            fillamnt = 0;
            cameranotcinemabitch.unEnd();
        
    }
    public void disableSelf()
    {
        this.GetComponent<buttonQuickTime>().enabled = false;
    }
}
//timeThreshold += Time.deltaTime;
//if (timeThreshold > .1)
//{
//    timeThreshold = 0;
//    titflex -= .2f;
//}
//GetComponent<Image>().fillAmount = titflex;
//if (inputManager.Honor())
//{
//    timeThreshold = 2f;
//    if (timeThreshold >= 0f)

//    {
//        Debug.Log("sdgf");

//        fuc.SetActive(true);

//        timeThreshold--;
//    }

//titflex += 1f;
//timeThreshold += 1f;

//if (timeThreshold <= 0f)
//{
//    fuc.SetActive(false);
//}