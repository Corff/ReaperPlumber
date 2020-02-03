using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHandler : MonoBehaviour
{
    public GameObject[] enemies = new GameObject[3];

    // Start is called before the first frame update
    void Start()
    {
        int amountOfEnemies = Random.Range(5,8);
        for (int i = 0; i < amountOfEnemies; i++)
        {
            int whichEnemy = Random.Range(0, 3);
            Instantiate(enemies[whichEnemy]);

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
