using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class armMovement : MonoBehaviour
{

    public Transform target;
    Vector2 look;

    void Update()
    {
        look = new Vector2(target.position.x, this.transform.position.y);
        transform.LookAt(look);
    }
}
