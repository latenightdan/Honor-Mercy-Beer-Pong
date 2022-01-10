using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class score : MonoBehaviour
{
    public Text scoreText;

    zombieDrink Score;
    public int sscore;
    public int scoreToWin = 3;

    GameObject me;

    GameObject Enemy;

   
    // Start is called before the first frame update
    void Start()
    {
        Enemy = GameObject.FindWithTag("zombie");
        me = GameObject.FindWithTag("player");
        //me.GetComponent<CameraNotCineMaBitch>().end();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void scoreHit(int scorePerHit2)
    {
        sscore = sscore + scorePerHit2; 
        scoreText.text = sscore.ToString();
        if (sscore == scoreToWin)
        {
            Enemy.GetComponent<Animator>().SetTrigger("test");
            me.GetComponent<CameraNotCineMaBitch>().finishHim();
            me.GetComponent<CameraNotCineMaBitch>().UIStuff();
        }

    }

}
