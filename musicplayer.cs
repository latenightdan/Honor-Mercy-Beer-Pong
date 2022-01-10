using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
public class musicplayer : MonoBehaviour
{
    private static musicplayer playerInstance;


    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        if (playerInstance == null)
        {
            playerInstance = this;
        }
       
    }

    // Start is called before the first frame update
    void Update()
    {
        OnSceneLoaded();
    }
  
    void OnSceneLoaded()
    {
        Scene scene = SceneManager.GetActiveScene();

        
        if (scene.name == "MAINmenu" || scene.name == "end")
        { 
            Destroy(gameObject);
            Debug.Log("I am inside the if statement");
        }
        
    }
}
