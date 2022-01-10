using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class buttonHandler : MonoBehaviour
{
    public Button honorButton;

    bool ispressed = false; 

   public void setText(string text)
    {
        Text txt = transform.Find("honor text").GetComponent<Text>();
        txt.text = text; 
    }
    public void honorPressed()
    {
        
    }
  
}
