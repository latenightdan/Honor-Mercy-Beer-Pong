using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class levelmanager : MonoBehaviour
{

    firstPersonInputSystem inputManager;
   

    public void startGame()
    {
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        if (SceneManager.sceneCountInBuildSettings > nextSceneIndex)
        {
            SceneManager.LoadScene(nextSceneIndex);
        }
    }
    public void loadMainMenu()
    {
        SceneManager.LoadScene("MAINmenu");
    }
}
