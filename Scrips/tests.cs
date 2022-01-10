
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;

public class tests : MonoBehaviour
{
    
    NewControls controls;


    private void Awake()
    {
        controls = new NewControls();
        controls.ThrowButton.Throw.performed += ctx => ThrowBall();

    }

    void OnEnable()
    {
        controls.ThrowButton.Enable();
    }
    void OnDisable()
    {
        controls.ThrowButton.Disable();
    }
    void ThrowBall()
    {
        GetComponentInChildren<Animator>().SetTrigger("ThrowFR");
    }

}