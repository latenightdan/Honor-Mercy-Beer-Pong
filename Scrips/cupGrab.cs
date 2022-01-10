using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cupGrab : MonoBehaviour
{
    [SerializeField] float force = 600f;
    [SerializeField] float drunkforce = 1f;
    Vector3 objectPos;
    //float distance;
    //public bool canHold = true;
    [SerializeField] GameObject cup;
    //public GameObject tempParent;
    //public bool isHolding = false; 
    [SerializeField] Transform hand;
    
   
    
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //check if is holding
        //if (isHolding == true)
        //    cup.GetComponent<Rigidbody>().velocity = Vector3.zero;
        //cup.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        //cup.transform.SetParent(tempParent.transform);
        
        //cup.transform.SetParent(null);
        //cup.GetComponent<Rigidbody>().useGravity = true;

    }
    void grabcup()
    {
       
        cup = Instantiate(cup, hand.transform.position, Quaternion.identity);
        idk();
        
    }
    public void idk()
    {



        cup.transform.SetParent(hand.transform);
        //cup.GetComponent<Rigidbody>().velocity = Vector3.zero * Time.deltaTime;
        //cup.GetComponent<Rigidbody>().angularVelocity = Vector3.zero * Time.deltaTime;

        cup.GetComponent<Rigidbody>().useGravity = false;
        cup.GetComponent<Rigidbody>().detectCollisions = false;
    }


    
        


    void discardCup()
    {

        //isHolding = false; 


        

        

        cup.GetComponent<Rigidbody>().AddForce(hand.transform.forward * force);
        cup.transform.SetParent(null);



        cup.GetComponent<Rigidbody>().useGravity = true;
            cup.GetComponent<Rigidbody>().detectCollisions = true;
              
    }
    void drunkdiscardCup()
    {

        //isHolding = false; 






        cup.GetComponent<Rigidbody>().AddForce(hand.transform.forward * drunkforce);
        cup.transform.SetParent(null);



        cup.GetComponent<Rigidbody>().useGravity = true;
        cup.GetComponent<Rigidbody>().detectCollisions = true;

    }
}
