using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class hideMouse : MonoBehaviour
{
    public bool CursorLockedVar;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = (false);
        CursorLockedVar = (true);
    }

    void Update()
    {
        if (Keyboard.current[Key.Escape].wasPressedThisFrame && !CursorLockedVar)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = (false);
            CursorLockedVar = (true); //todo add pause menu stuff
        }
        else if (Keyboard.current[Key.Escape].wasPressedThisFrame && CursorLockedVar)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = (true);
            CursorLockedVar = (false);
        }
    }


}

