
using UnityEngine;
using UnityEngine.InputSystem;

public class WWeaponnn : MonoBehaviour
{
    firstPersonInputSystem inputManager;
    LauncherFPS controls;


    //[SerializeField] Camera cc;

    [SerializeField] float range = 100f;

    public ParticleSystem muzzleFlash;

    
    // Update is called once per frame

  
    void Update()
    {
      
       
    }

    public void Shoot()
    {
        PPlayMuzzleFlash();

    }

    public void PPlayMuzzleFlash()
    {
        muzzleFlash.Play();
    }

    //private void ProcessRayCast()
    //{
    //    RaycastHit hit;
    //    Physics.Raycast(cc.transform.position, cc.transform.forward, out hit, range);
    //    Debug.Log(hit.transform.name);
    //}
}
