using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;



public class Throww : MonoBehaviour
{
    [SerializeField] float force = 600;
    float sucks;

    Vector3 piss;

    [SerializeField] GameObject ball;
    [SerializeField] Transform parent;
    [SerializeField] Transform player;
    [SerializeField] float ballRespawnTime = 1f;
    [SerializeField] int ballLimit = 6;
    TrajectoryPredictor tp;
    public Text infoText;

    public bool isSucking = true;
    int numBalls = 0;

    Queue<GameObject> ballQueue = new Queue<GameObject>();

    //[SerializeField] List<Throww> balls;



    //this is for creating ball repeats
    //[SerializeField] int ballLimit = 5;
    //Queue<Throww> ballQueue = new Queue<Throww>();



    

    // Update is called once per frame
    private void Start()
    {
        idk();
        sucks = Vector3.Distance(ball.transform.position, parent.transform.position);
        tp = gameObject.AddComponent<TrajectoryPredictor>();
        tp.drawDebugOnPrediction = true;
        tp.reuseLine = true; //set this to true so the line renderer gets reused every frame on prediction
        tp.accuracy = 0.99f;
        tp.lineWidth = 0.03f;
        tp.iterationLimit = 600;
    }


    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            ThrowBall();

        }
    }

    public void ThrowBall()
    {
        
        GetComponentInChildren<Animator>().SetTrigger("ThrowFR");


    }

    public void idk()
    { 
        if(isSucking == true)
    {
            
            ball.transform.SetParent(parent.transform);
            ball.GetComponent<Rigidbody>().velocity = Vector3.zero * Time.deltaTime;
        ball.GetComponent<Rigidbody>().angularVelocity = Vector3.zero * Time.deltaTime;
        
        ball.GetComponent<Rigidbody>().useGravity = false;
        ball.GetComponent<Rigidbody>().detectCollisions = false;
            
           

        }

    }
   public void throwwwwwww()
    {
        isSucking = false;

       


        ball.transform.SetParent(null);
            ball.GetComponent<Rigidbody>().AddForce(player.forward * force);
            ball.GetComponent<Rigidbody>().useGravity = true;
            ball.GetComponent<Rigidbody>().detectCollisions = true;
   
        GetComponentInChildren<Animator>().SetTrigger("ThrowFR");
        Invoke("makeNewBall", ballRespawnTime);


    }

    //GameObject launchObjParent;
    //void Launch()
    //{
    //    if (!launchObjParent)
    //    {
    //        launchObjParent = new GameObject();
    //        launchObjParent.name = "Launched Objects";
    //    }
    //    GameObject lInst = Instantiate(ball);
    //    lInst.name = "Ball";
    //    lInst.transform.SetParent(launchObjParent.transform);
    //    Rigidbody rbi = lInst.GetComponent<Rigidbody>();
    //    lInst.transform.position = parent.position;
    //    lInst.transform.rotation = parent.rotation;
    //    rbi.velocity = parent.forward * force;

    //    Renderer tR = lInst.GetComponent<Renderer>();
    //    tR.material = Instantiate(tR.material) as Material;

    //}

    public void makeNewBall()
    {
        numBalls = ballQueue.Count;
        if (numBalls < ballLimit)
        {
            MakeBall();
            print(ballQueue.Count);
        }
       

    }
    void LateUpdate(){
		//set line duration to delta time so that it only lasts the length of a frame
		tp.debugLineDuration = Time.deltaTime;
		//tell the predictor to predict a 3d line. this will also cause it to draw a prediction line
		//because drawDebugOnPredict is set to true
		tp.Predict3D(parent.position, parent.forward * force, Physics.gravity);

		//this static method can be used as well to get line info without needing to have a component and such
		//TrajectoryPredictor.GetPoints3D(launchPoint.position, launchPoint.forward * force, Physics.gravity);

		//info text stuff
		if(infoText){
			//this will check if the predictor has a hitinfo and then if it does will update the onscreen text
			//to say the name of the object the line hit;
			if(tp.hitInfo3D.collider)
				infoText.text = "Hit Object: " + tp.hitInfo3D.collider.gameObject.name;
		}
	}


    private void MakeBall()
    {
        
        ball = Instantiate(ball, parent.transform.position, Quaternion.identity);
       
        isSucking = true;
        idk();
    }
  

  



}

//unused coroutine just in case I need one lol
//IEnumerator BallCache()
//{
//    foreach (Throww ball in balls)
//    {
//        print("balls");
//        yield return new WaitForSeconds(1f);

//    }
//}