using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AIThrow : MonoBehaviour
{


    bool isSucking = true;
    public GameObject ball;
    float ballRespawnTime = 1f;
    [SerializeField] Transform blastpoint;
    public float force = 1f;
    public GameObject objToLaunch;
    public Transform Target;
    
    public float firingAngle = 45.0f;
    

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("throwwwwwww", 2.0f, 2f);
        
    }

    // Update is called once per frame
    void Update()
    {
        
         

            }
        
        
    
       


        GameObject launchObjParent;
        void throwwwwwww()
        {
            if (!launchObjParent)
            {
                launchObjParent = new GameObject();
                launchObjParent.name = "Launched Objects";

            }
            

            GameObject lInst = Instantiate(objToLaunch);
            lInst.name = "ball";
            lInst.transform.SetParent(launchObjParent.transform);
            Rigidbody rigidbody = lInst.GetComponent<Rigidbody>();

            lInst.transform.position = blastpoint.position;
            lInst.transform.rotation = blastpoint.rotation;

        blastpoint.rotation = Quaternion.LookRotation(Target.position - blastpoint.position);

        float target_Distance = Vector3.Distance(blastpoint.position, Target.position);
        rigidbody.velocity = blastpoint.forward * force;

        //float projectile_Velocity = target_Distance / (Mathf.Sin(2 * firingAngle * Mathf.Deg2Rad));

        //float Vx = Mathf.Sqrt(projectile_Velocity) * Mathf.Cos(firingAngle * Mathf.Deg2Rad);

        //float Vy = Mathf.Sqrt(projectile_Velocity) * Mathf.Sin(firingAngle * Mathf.Deg2Rad);

        //float flightDuration = target_Distance / Vx;









    }
   
}
