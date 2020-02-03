using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorScript : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = new Vector3(0, 0, -99999999999);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (GameObject.FindWithTag("Enemy") == null)
            {
                if (SombreroMachine.completeCount == 5)
                {
                    SceneManager.LoadScene(3);
                } else
                {
                    SceneManager.LoadScene(2);
                }
            }
            else
            {
                Debug.Log("destroy all enemies!");
            }
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindWithTag("Enemy") == null)
        {
            gameObject.transform.position = new Vector3(0, 0, 0);
        }
    }
}
