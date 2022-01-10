using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggers : MonoBehaviour
{
    weapon weapon;
    GameObject Enemy;
    
    [SerializeField] float hitpoints = 1f;
    // Start is called before the first frame update
    void Start()
    {
        weapon = GetComponentInChildren<weapon>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(float damage)
    {
        hitpoints -= damage;
        if (hitpoints <= 0)
        {
            GetComponent<Animator>().SetTrigger("honor");
        }
    }
    void trig()
    {
        GetComponent<Animator>().SetTrigger("something else");
    }
    void trig2()
    {
        GetComponent<Animator>().SetTrigger("drunkTime");
    }
    void trig3()
    {
        GetComponent<Animator>().SetTrigger("kill");
    }
    public void shoot()
    {
        weapon.Shoot();
    }
   
}
