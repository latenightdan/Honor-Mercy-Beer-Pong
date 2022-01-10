using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallHitCup1 : MonoBehaviour
{
    float delay = 1.6f;
    

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


    GameObject zombie;
    public int scorePerHit = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        zombie = GameObject.FindWithTag("zombie");
        bounceSource = gameObject.AddComponent<AudioSource>();
        sinkSource = gameObject.AddComponent<AudioSource>();
        rimSource = gameObject.AddComponent<AudioSource>();
        

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
        else if (collisionWith.tag == "alc")
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
            if (time == 0f)
            {
                zombie.GetComponent<Animator>().SetTrigger("something");


                Destroy(collision.gameObject, delay);
                
            }
        }

    }

}





