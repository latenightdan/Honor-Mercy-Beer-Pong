using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;

public class LauncherFPS : MonoBehaviour {

	

	public GameObject objToLaunch;
    //public Transform handFollower;
    public Transform launchPoint;
    [SerializeField] GameObject ball;
    public Text infoText;
	public bool launch;
	[Range(1, 150)]
	[SerializeField]
	public float force = 150f;
    NewControls controls;

	private bool holdbutton;
	private bool holdbutton2;
	//fuck with these heavy tmrrwww
	public float moveSpeed = 1f;

	//create a trajectory predictor in code
	TrajectoryPredictor trajectorypredictor;


	private void Awake()
    {
        controls = new NewControls();
        controls.ThrowButton.Throw.performed += ctx => ThrowBall();
		//controls.ThrowButton.ThrowPlus.performed += ctx => ThrowPlus();
		
		//controls.ThrowButton.ThrowMinus.performed += ctx => ThrowMinus();
		
		trajectorypredictor = FindObjectOfType<TrajectoryPredictor>();
		trajectorypredictor.drawDebugOnPrediction = true;
		trajectorypredictor.reuseLine = true; //set this to true so the line renderer gets reused every frame on prediction
		trajectorypredictor.accuracy = 0.99f;
		trajectorypredictor.lineWidth = 0.03f;
		trajectorypredictor.iterationLimit = 600;
	}


    void Start(){
	
	}

	// Update is called once per frame
	void Update () {

		//input stuff

		//Mouse.current.leftButton.wasPressedThisFrame
		//Debug.Log("Throw Control Value" + throwControlValue);

		//if (Input.GetMouseButton(1) || Input.GetKey(KeyCode.UpArrow))
		if (holdbutton)
		{ 
			Debug.Log("pressing");
		    force += moveSpeed / 10f;
		}
		if(holdbutton2)
		{ 
			force -= moveSpeed / 10f;
		}

		force = Mathf.Clamp(force, 1f, 150f);
		

		if (launch) {
			
			launch = false;
			Launch();
		}
	}




    void OnEnable()
    {
        controls.ThrowButton.Enable();
		controls.ThrowButton.ThrowMinus.performed += ThrowMinus;
		controls.ThrowButton.ThrowPlus.performed += ThrowPlus;
		controls.ThrowButton.ThrowMinus.Enable();
		controls.ThrowButton.ThrowPlus.Enable();
	}
    void OnDisable()
    {
        controls.ThrowButton.Disable();
		controls.ThrowButton.ThrowMinus.Disable();
		controls.ThrowButton.ThrowPlus.Disable();
	}
    void ThrowBall()
    {
		GetComponentInChildren<Animator>().SetTrigger("ThrowFR");
	}
	private void ThrowPlus(InputAction.CallbackContext obj)
	{
		
		var value2 = obj.ReadValue<float>();
		holdbutton2 = value2 >= 0.9f;
	}
	
	private void ThrowMinus(InputAction.CallbackContext obj)
    {
		var value = obj.ReadValue<float>();
		holdbutton = value >= 0.9f;

	}
	void LateUpdate(){
		//set line duration to delta time so that it only lasts the length of a frame
		trajectorypredictor.debugLineDuration = Time.unscaledDeltaTime;
		//tell the predictor to predict a 3d line. this will also cause it to draw a prediction line
		//because drawDebugOnPredict is set to true
		trajectorypredictor.Predict3D(launchPoint.position, launchPoint.forward * force, Physics.gravity);

        //this static method can be used as well to get line info without needing to have a component and such
        TrajectoryPredictor.GetPoints3D(launchPoint.position, launchPoint.forward * force, Physics.gravity);

        //info text stuff
  //      if (infoText){
		//	//this will check if the predictor has a hitinfo and then if it does will update the onscreen text
		//	//to say the name of the object the line hit;
		//	if(trajectorypredictor.hitInfo3D.collider)
		//		infoText.text = "Hit Object: " + trajectorypredictor.hitInfo3D.collider.gameObject.name;
		//}
	}


    GameObject launchObjParent;
	void Launch(){
		if(!launchObjParent){
			launchObjParent = new GameObject();
			launchObjParent.name = "Launched Objects";
			
		}
		
		GameObject lInst = Instantiate (objToLaunch);
		lInst.name = "Ball";
		lInst.transform.SetParent(launchObjParent.transform);
		Rigidbody rbi = lInst.GetComponent<Rigidbody> ();
		lInst.transform.position = launchPoint.position;
		lInst.transform.rotation = launchPoint.rotation;
		rbi.velocity = launchPoint.forward * force;

		Physics.IgnoreCollision(lInst.GetComponent<SphereCollider>(), GetComponent<CapsuleCollider>(), true);
		
		
		GetComponentInChildren<Animator>().SetTrigger("ThrowFR");
		Invoke("ballReset", 1f);

	}
	void ballReset()
    {
		ball.SetActive(true);
	}


	
	void stopDrinking()
    {
		GetComponent<Animator>().SetTrigger("stopDrinking");
    }
	public void end()
    {
		Destroy(trajectorypredictor);
    }
	//public void disablePredictor()
 //   {
		
 //   }
	
}

//public void idk()
//{
//    {
//        ball.transform.SetParent(handFollower.transform);

//    }
//}

//ball.SetActive(false);

//Renderer tR = lInst.GetComponent<Renderer>();
//tR.material = Instantiate(tR.material) as Material;

//Color RandomColor(){
//	float r = Random.Range (0.0f, 1.0f);
//	float g = Random.Range (0.0f, 1.0f);
//	float b = Random.Range (0.0f, 1.0f);
//	return new Color(r,g,b);
//}

//tR.material.color = RandomColor();

//for idk()
//ball.GetComponent<Rigidbody>().velocity = Vector3.zero * Time.deltaTime;
//ball.GetComponent<Rigidbody>().angularVelocity = Vector3.zero * Time.deltaTime;

//ball.GetComponent<Rigidbody>().useGravity = false;
//ball.GetComponent<Rigidbody>().detectCollisions = false;