using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class level1text : MonoBehaviour
{

    [SerializeField] Canvas LEVEL1Canvas;
    public GameObject LEVEL1;
    public float wait = .5f;

    // Start is called before the first frame update
    void Awake()
    {
        StartCoroutine(CUNT());

        IEnumerator CUNT()
        {


            LEVEL1.SetActive(true);


            yield return new WaitForSeconds(1);
            LEVEL1.SetActive(false);



        }

    }

}

