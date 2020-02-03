using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossFreezeAttack : MonoBehaviour
{
    bool leftOrRight;  //False left, True Right
    public GameObject left;
    public GameObject right;
    
    // Start is called before the first frame update
    void Start()
    {
        leftOrRight = (Random.Range(0, 2) > 0) ? true : false;

        if (leftOrRight == true)
        {
            right.SetActive(true);
        }
        else
        {
            left.SetActive(true);
        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
