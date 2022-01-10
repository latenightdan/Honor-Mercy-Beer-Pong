using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class hitCup : MonoBehaviour
{
    [SerializeField] float sinkCupDelay = 1f;

    
    Score piss;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        
        foreach (ContactPoint contact in collision.contacts)
        {
            var colName = contact.thisCollider.name;
            switch (colName)
            {
                case "cup":
                    Debug.Log("cup");
                    break;
                case "alc":
                    Destroy(gameObject, sinkCupDelay);
                    
                    Debug.Log("alc");
                    break;
                
            }
           
        }
    }
}
