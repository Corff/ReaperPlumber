using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{

    public GameObject Enemy;
    // Start is called before the first frame update
    void Start()
    {
        int rand = Random.Range(5, 7);

        for(int i = 0; i < rand; i++)
        {
            Instantiate(Enemy);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
