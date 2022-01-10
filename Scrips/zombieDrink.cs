using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombieDrink : MonoBehaviour
{
    
    GameObject zombie;
    public PhysicMaterial lessbouncy;
    float time = 3f;
    public int scorePerHit = 1;
    public int scoreToGetDrunk;

    [Header("sounds")]
    public AudioClip bounce;
    public AudioClip sink;
    public AudioClip sink2;
    public AudioClip rim;
    [Header("corresponding audiosources")]
    public AudioSource bounceSource;
    public AudioSource sinkSource;
    public AudioSource sinkSource2;
    public AudioSource rimSource;

    GameObject me;

    
    
    score scoreboard;

    // Start is called before the first frame update
    void Start()
    {
        me = GameObject.FindWithTag("player");
        Physics.IgnoreCollision(me.GetComponent<Collider>(), GetComponent<Collider>(), true);
        zombie = GameObject.FindWithTag("zombie");
        scoreboard = FindObjectOfType<score>();
        

        //crowd = GameObject.FindGameObjectsWithTag("crowd");
        //me.GetComponent<CameraNotCineMaBitch>().end();
        bounceSource = GetComponent<AudioSource>();
        sinkSource = GetComponent<AudioSource>();
        rimSource = GetComponent<AudioSource>();
        sinkSource2 = GetComponent<AudioSource>();

        //todo find way to select multiple objects with tag and/or layer at once to trigger crowd drink

    }

    // Update is called once per frame
    void Update()
    {


    }
    //private void OnTriggerStay(Collider other)
    //{
    //    time--;
    //    if(time == 0f)
    //    {
    //        zombie.GetComponent<Animator>().SetTrigger("something");
    //    }
    //}



    void OnCollisionStay(Collision collision)
    {

        var collisionWith = collision.GetContact(0).otherCollider;


        if (collisionWith.tag == "enemy alc" && scoreboard.sscore <= scoreToGetDrunk)
        {
            sinkSource.PlayOneShot(sink);
            time--;
            if (time == 0f)
            {
                sinkSource2.PlayOneShot(sink2);
                //GameObject tim = collision.gameObject;
                //tim.GetComponent<Collider>().enabled = false;
                //todo make cool cup destroy effect
                Destroy(collision.gameObject);
                zombie.GetComponent<Animator>().SetTrigger("something");
                GameObject[] crowd = GameObject.FindGameObjectsWithTag("crowd");
                foreach (GameObject fan in crowd)
                { fan.GetComponent<Animator>().SetTrigger("cheer"); }
                scoreboard.scoreHit(scorePerHit);
                
            }
        }
       

        else if (collisionWith.tag == "enemy alc" && scoreboard.sscore >= scoreToGetDrunk)
        {
            sinkSource.PlayOneShot(sink, 0.7f);
            time--;
            if (time == 0f)
            {
                sinkSource2.PlayOneShot(sink2);
                GameObject[] crowd = GameObject.FindGameObjectsWithTag("crowd");
                foreach (GameObject fan in crowd)
                { fan.GetComponent<Animator>().SetTrigger("cheer"); }
                zombie.GetComponent<Animator>().SetTrigger("Winning");
                Destroy(collision.gameObject);
                scoreboard.scoreHit(scorePerHit);
            }
            

        }
       
    }


    void OnCollisionEnter(Collision collision)
    {
      
            bounceSource.PlayOneShot(bounce, 0.7F);

        var collisionWith = collision.GetContact(0).otherCollider;

        Debug.Log(collisionWith.gameObject.name);

        if (collisionWith.tag == "cup")
        {
            rimSource.PlayOneShot(rim, 0.7f);
            GetComponent<SphereCollider>().material = lessbouncy;
        }
        if (collisionWith.tag == "enemy alc")
        {
            
            //Debug.Log("alc");
            GetComponent<SphereCollider>().material = lessbouncy;

           

        }
    }

  

}









//void OnCollisionStay(Collision collision)
//{

//    var collisionWith = collision.GetContact(0).otherCollider;


//   //if (collisionWith.tag == "alc" && scoreboard.sscore <=1)
//   // {
//   //     Debug.Log("alc");
//   //     time--;
//   //     if(time == 0f)
//   //     { 
//   //     zombie.GetComponent<Animator>().SetTrigger("something");
//   //         Destroy(collision.gameObject, 1.95f);
//   //         scoreboard.scoreHit(scorePerHit);
//   //     }
//   // }


//    if (collisionWith.tag == "alc" && scoreboard.sscore >= scoreToGetDrunk)
//    {
//        time--;
//        if (time == 0f)
//        {

//            zombie.GetComponent<Animator>().SetTrigger("Winning");
//            Destroy(collision.gameObject, 1.95f);
//            scoreboard.scoreHit(scorePerHit);
//        }

//    }
//   if (collisionWith.tag == "alc" && scoreboard.sscore == scoreToWin)
//    {
//        time--;
//        if (time == 0f)
//        {
//            me.GetComponent<CameraNotCineMaBitch>().end();
//            //zombie.GetComponent<Animator>().SetTrigger("StopThrowing");
//            Destroy(collision.gameObject, 1.95f);
//            scoreboard.scoreHit(scorePerHit);
//        }
//    }
//}