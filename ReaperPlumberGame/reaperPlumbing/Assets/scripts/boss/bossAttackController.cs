using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossAttackController : MonoBehaviour
{

    public GameObject bCA;
    public GameObject bFA;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(waitForSeconds(0, Random.Range(0,2)));
    }


    IEnumerator waitForSeconds(float a, int b)
    {
        yield return new WaitForSeconds(a);
        GameObject attack;
        if(b == 0)
        {
            attack = Instantiate(bFA);
        }
        else
        {
            attack = Instantiate(bCA);
        }
        Destroy(attack,3);
        StartCoroutine(waitForSeconds(3, Random.Range(0, 2)));
    }
}
