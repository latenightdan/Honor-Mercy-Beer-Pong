using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killself : MonoBehaviour
{

    public GameObject player;

    public void OnDisable()
    {
        gameObject.active = false;
    }
    public void enablePlayer()
    {
        player.active = true;
    }
}
