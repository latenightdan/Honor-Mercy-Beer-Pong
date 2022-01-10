using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{
    [SerializeField] float range = 100f;
    public ParticleSystem muzzleFlash;
    AudioSource audioSource;
    public AudioClip impact;
    [SerializeField] Canvas deathcanvas;

    public GameObject blood;
    PlayerHealth jimmm;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        jimmm = FindObjectOfType<PlayerHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Shoot()
    {
        PPlayMuzzleFlash();
        audioSource.PlayOneShot(impact, 0.7F);
        blood.GetComponent<Animator>().SetTrigger("james");

    }

    public void PPlayMuzzleFlash()
    {
        muzzleFlash.Play();
        
    }
   public void dieAgain()
    {
        jimmm.GetComponent<Animator>().SetTrigger("die");
    }

}
