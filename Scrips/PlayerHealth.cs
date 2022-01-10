using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    GameObject Enemy;
    CameraNotCineMaBitch executeHim;

    buttonQuickTime buttonqt;

    public Text lifeText;
    public int life = 1;
    public static int lifestolose = 3;



    public int points;
    public int scoreToLose = 3;
    // Start is called before the first frame update
    void Start()
    {
        Enemy = GameObject.FindWithTag("zombie");
        executeHim = FindObjectOfType<CameraNotCineMaBitch>();
        buttonqt = FindObjectOfType<buttonQuickTime>();
        
        
    }
    private void Update()
    {
        LIFES();
    }
    public void scoreHit(int scorePerHit)
    {
        points = points + scorePerHit;
        
        if (points == scoreToLose)
        {
            lifestolose = lifestolose - life;
            Scene scene = SceneManager.GetActiveScene();
            if (scene.name == "ROUND 1")
            {
                Debug.Log("loseee");
                buttonqt.enabled = false;
                enemyWin();
                //reload();
                nextScene();
                executeHim.finishHim();
            }

            if (lifestolose < life)
            {
                Debug.Log("loseee");
            buttonqt.enabled = false;
            enemyWin();
            //reload();
            MM();
            executeHim.finishHim();
            }
            else if (lifestolose >= life)
            {
                Debug.Log("not lose");
                buttonqt.enabled = false;
                enemyWin();
                reload();
                //MM();
                executeHim.finishHim(); //this is what was giving me issues i think
            }
        }
    }





    public void LIFES()
    {
        
        lifeText.text = lifestolose.ToString();


    }






    public void addLife()
    {
        lifestolose = lifestolose + life;
    }





    public void enemyWin()
    {
        Enemy.GetComponent<Animator>().SetTrigger("KILL");
        GetComponent<Animator>().SetTrigger("lose");
        
    }
    public void reload()
    {
        StartCoroutine(reloadgame());

        IEnumerator reloadgame()
        {
            yield return new WaitForSeconds(5);

            ReloadGame();
        }



    }

    public void MM()
    {
        StartCoroutine(MM());

        IEnumerator MM()
        {
            yield return new WaitForSeconds(5);

            mainMenu();
        }



    }


    public void mainMenu()
    {
        SceneManager.LoadScene("MAINmenu");
    }

    public void ReloadGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void loadnextscene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void nextScene()
    {
        StartCoroutine(loadNext());

        IEnumerator loadNext()
        {
            yield return new WaitForSeconds(4);

            loadnextscene();
        }



    }
}
