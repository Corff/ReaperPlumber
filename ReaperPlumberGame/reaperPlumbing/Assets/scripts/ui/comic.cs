using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class comic : MonoBehaviour
{
    public GameObject[] comics = new GameObject[99];

    public int length = 0;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            //comics[length].SetActive(false);
            if(length <= 3)
            {
                comics[length+1].SetActive(true);
            }
            else
            {
                SceneManager.LoadScene(4);
            }
            length++;

        }
    }
}
