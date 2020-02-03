using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPosScript : MonoBehaviour
{
    void Start()
    {
        Vector2 posToMove = new Vector2(Random.Range(-39.9f, 39.9f), Random.Range(-19.9f, 19.9f));
        transform.localPosition = posToMove;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
