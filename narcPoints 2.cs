using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class narcPoints : MonoBehaviour
{

    public static int narcs = 3;
    public Text narcText;
    public int narcPoint = 1;
    narcoticsUpgrade narcoticsupgrade;
    firstPersonInputSystem inputManager;
    public ParticleSystem throwUp;


    // Start is called before the first frame update

    
    private void Awake()
    {
        inputManager = firstPersonInputSystem.Instance;
        //throwUp.enableEmission = false;
        
        narcText = GetComponent<Text>();
        narcoticsupgrade = FindObjectOfType<narcoticsUpgrade>();
    }

    void Start()
    {
      
        //narcs = PlayerPrefs.GetInt("narcs");
    }

    // Update is called once per frame
    void Update()
    {
        if (inputManager.Narc() && narcs > 0)
        {
            FindObjectOfType<AudioManager>().Play("barf 1");
            ThrowUp();
            narcoticsupgrade.DecreaseAll();
            narcs -= narcPoint;

        }

        narcText.text = narcs.ToString();
        //PlayerPrefs.SetInt("narcs", narcs);
        
    }
    public void narcHit(int narcsPerHit)
    {
        narcs = narcs + narcsPerHit;
        narcText.text = narcs.ToString();
      

    }
    void ThrowUp()

    {
        StartCoroutine(it());

        IEnumerator it()
        {
            throwUp.enableEmission = true;
            yield return new WaitForSeconds(1f);
            throwUp.enableEmission = false;
        }
    }

}
