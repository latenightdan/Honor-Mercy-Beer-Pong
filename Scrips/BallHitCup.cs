using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallHitCup : MonoBehaviour
{
    float delay = 1.6f;
    GameObject player;

    Demo demo;
    float time = 3f;

    [Header("sounds")]
    public AudioClip bounce;
    public AudioClip bounceLite;
    public AudioClip bounceSupaLite;
    public AudioClip sink;
    public AudioClip rim;
    [Header("corresponding audiosources")]
    public AudioSource bounceSource;
    public AudioSource sinkSource;
    public AudioSource rimSource;
    public AudioSource bounceLiteSource;
    public AudioSource bounceSupaLiteSource;

    qte drinky;
    buttonQuickTime buttonquicktime;
    CameraNotCineMaBitch cameranotcinemabitch;
    PlayerHealth pointBoard;
    drunkControl drunkcontrol;

    
    public int scorePerHit = 1;

   
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("player");
        bounceSource = gameObject.AddComponent<AudioSource>();
        sinkSource = gameObject.AddComponent<AudioSource>();
        rimSource = gameObject.AddComponent<AudioSource>();
        pointBoard = FindObjectOfType<PlayerHealth>();
        drinky = FindObjectOfType<qte>();
        drunkcontrol = FindObjectOfType<drunkControl>();
        

        cameranotcinemabitch = FindObjectOfType<CameraNotCineMaBitch>();

        buttonquicktime = FindObjectOfType<buttonQuickTime>();
    }

    // Update is called once per frame
    void Update()
    {
        
       
    }
    void OnCollisionEnter(Collision collision)
    {
        
        var collisionWith = collision.GetContact(0).otherCollider;

        //Debug.Log(collision.relativeVelocity.magnitude);
        if (collision.gameObject.layer == default && collision.relativeVelocity.magnitude >= 2)
        { 
        bounceSource.PlayOneShot(bounce, 0.7F);
        }
        if (collision.gameObject.layer == default && collision.relativeVelocity.magnitude <= 2)
        {

            bounceLiteSource.PlayOneShot(bounceLite, 0.7F);
            
        }
      

        if (collisionWith.tag == "cup")
        {
            
            rimSource.PlayOneShot(rim, 0.7f);
            Debug.Log(collision.relativeVelocity);
        }
        if (collisionWith.tag == "alc")
        {
            sinkSource.PlayOneShot(sink, 0.7f);





        }
    }
    private void OnCollisionStay(Collision collision)
    {
        var collisionWith = collision.GetContact(0).otherCollider;
        if (collisionWith.tag == "alc")
        {
            
            time--;
            if (time == 0f && buttonquicktime.freeze)
            {
               
                   
                    buttonquicktime.bigTit2();
                    player.GetComponent<Animator>().SetTrigger("drink"); //possible pain point as well
                    buttonquicktime.setDrinky(); //since this is true, the else statement becomes true immediately. find another condition
                    cameranotcinemabitch.end();
                    Destroy(collision.gameObject, delay);
                    pointBoard.scoreHit(scorePerHit);
                Debug.Log("not");
                    
                
              
            }
            if (time == 0f && !buttonquicktime.freeze)
            {
                Debug.Log("pussyyyyy");
                buttonquicktime.bigTit2();
                drunkcontrol.increaseAll();
                buttonquicktime.resetDrink();
                Destroy(collision.gameObject, delay);
                pointBoard.scoreHit(scorePerHit);

            }
        
                
            
            
        }
     
    }
   
}





