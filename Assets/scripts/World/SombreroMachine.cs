using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SombreroMachine : MonoBehaviour
{
    static public int completeCount;
    public GameObject Enemy;
    public GameObject Wall;

    void Start()
    {
        completeCount = completeCount + 1;
      //  for(int i=0; i<6; i++)
        //{
          //  Enemy = Instantiate(Enemy);
        //}
        for(int i=0; i<50; i++)
        {
            Wall = Instantiate(Wall);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
