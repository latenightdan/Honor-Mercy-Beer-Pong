using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class QTEvent : MonoBehaviour
{

    [SerializeField] Canvas honorMercyCanvas; 
    public float pressedFlashTime = .2f;
    public float pointTime = 2f;
    public GameObject honorFlash;

    public GameObject mercyFlash;
    private firstPersonInputSystem inputManager;

    public GameObject vomitpoint;
    public GameObject lifepoint;


    void Awake()
    {


     
        inputManager = firstPersonInputSystem.Instance;


    }

    // Start is called before the first frame update
    void Start()
    {
        honorMercyCanvas.enabled = false;
        vomitpoint.SetActive(false);
        honorFlash.SetActive(false);
        mercyFlash.SetActive(false);
        lifepoint.SetActive(false);
        
    }

    // Update is called once per frame
   

    void Update()
    {


        if (inputManager.Honor())
        {
            flash();
            //flash2();
        }
        if (inputManager.Mercy())
        {
            mercyyyything();
            //othermercything();
        }

           


    }
    public void honorMercyHandler()
    {
        honorMercyCanvas.enabled = true;

    }



    public void flash()
    {
        StartCoroutine(honorrr());

        IEnumerator honorrr()
        {

            {

                honorFlash.SetActive(true);

                yield return new WaitForSeconds(pressedFlashTime);
                honorFlash.SetActive(false);

            }
        }
        StartCoroutine(vomitpt());

        IEnumerator vomitpt()
        {

            {

                vomitpoint.SetActive(true);

                yield return new WaitForSeconds(pointTime);
                vomitpoint.SetActive(false);

            }
        }

        //todo this is so fucking stupid. It's on the exact same script and for some reason it doesn't call it
    }
    //public void flash2()
    //{
    //    StartCoroutine(vomitpt());

    //    IEnumerator vomitpt()
    //    {

    //        {

    //            vomitpoint.SetActive(true);

    //            yield return new WaitForSeconds(pointTime);
    //            vomitpoint.SetActive(false);

    //        }
    //    }
    //}
    public void mercyyyything()
    {
        StartCoroutine(LateCall());

        IEnumerator LateCall()
        {


            mercyFlash.SetActive(true);

            yield return new WaitForSeconds(pressedFlashTime);
            mercyFlash.SetActive(false);
            //reload();


        }
        StartCoroutine(snuffFilm());

        IEnumerator snuffFilm()
        {


            lifepoint.SetActive(true);

            yield return new WaitForSeconds(pointTime);
            lifepoint.SetActive(false);
            //reload();


        }
    }
    //public void othermercything()
    //{
    //    StartCoroutine(snuffFilm());

    //    IEnumerator snuffFilm()
    //    {


    //        lifepoint.SetActive(true);

    //        yield return new WaitForSeconds(pointTime);
    //        lifepoint.SetActive(false);
    //        //reload();


    //    }
    //}

    //public void reload()
    //{
    //    StartCoroutine(jimmy());

    //        IEnumerator jimmy()
    //    {
    //        yield return new WaitForSeconds(4);

    //        gunk.ReloadGame();
    //    }



    //}

    //all this could be used for a cool drinking quick time event. Think about it

    //public float titflex = 0;

    //public float timeThreshold = 0;

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
}

