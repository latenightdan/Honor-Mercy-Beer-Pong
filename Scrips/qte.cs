using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//Don't Forget This
using UnityEngine.InputSystem;
public class qte : MonoBehaviour
{

    public Slider quickTimeSlider;
    public Text keyToPress;

    [SerializeField] Canvas quickTimeCanvas;
   public bool freeze;//Stops slider from moving

    public bool rapidPress; //The Type Of Quick Time Event
    public int decreaseSpeed;//Speed Slider Decreases   

    //KeyCode key;//The Key That Should Be Pressed To React To The QTE
    //KeyCode[] availableOptions = { KeyCode.Alpha1, KeyCode.Alpha2 }; //Numerical Keys 1 And 2, Chosen Randomly For Player To React To


    public bool drinky = false;

    GameObject player;

    private firstPersonInputSystem inputManager;



    void Awake()
    {



        inputManager = firstPersonInputSystem.Instance;


    }




    // Use this for initialization
    void Start()
    {
        quickTimeCanvas.enabled = false;
        player = GameObject.FindWithTag("player");
        //Randomly Selects The Key That Should Be Pressed And Displays It To The Player
        //int rand = Random.Range(0, 2);
        //key = availableOptions[rand];
        //keyToPress.text = availableOptions[rand].ToString();

        //The Type Of QTE Determines Where The Slider Starts
        if (rapidPress)
        {
            quickTimeSlider.value = 5;//Start In The Middle, The Player Has To Quickly Press The Key To Make The Meter Full
        }
      
    }


    void Update()
    {

        if (drinky)
        {
            quickTimeCanvas.enabled = true;
            //drinkQte();
            //Move Value Of Slider Towards 0, If The QTE Has Yet To Be Passed Or Failed      
            daDrinky();
        }
       else
        {
            freeze = true;
        }
    }

    public void daDrinky()
    {
        freeze = false;
        if (!freeze)
        {
            quickTimeSlider.value = Mathf.MoveTowards(quickTimeSlider.value, 0, decreaseSpeed * Time.deltaTime);
            
        }

        if (rapidPress)
        {
            if (inputManager.PlayerJump() && quickTimeSlider.value > 0)
            {
                quickTimeSlider.value += 1f;
                if (quickTimeSlider.value == 10)
                {
                    player.GetComponent<Animator>().SetTrigger("drink2");
                    keyToPress.text = "Pass!";
                    
                    
                    drinky = false;
                    quickTimeCanvas.enabled = false;
                    quickTimeSlider.value = 5;
                    //quickTimeCanvas.enabled = false;

                }
            }
        }

        

      
    }

    //public void drinkQte()
    //{
    //    quickTimeCanvas.enabled = true;
    //}

    public void setDrinky()
    {
        drinky = true;
        
        
    }
    //public void unDrinky()
    //{
    //    drinky = false;
    //    quickTimeCanvas.enabled = false;
        
    //}

}