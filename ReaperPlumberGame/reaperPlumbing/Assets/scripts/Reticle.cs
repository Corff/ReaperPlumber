using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reticle : MonoBehaviour
{

    Vector2 pos;

    public Camera cam;

    // Update is called once per frame
    void Update()
    {
        Cursor.lockState = CursorLockMode.Locked;

        pos.x = pos.x + Input.GetAxisRaw("Mouse X");

        pos.y = pos.y + Input.GetAxisRaw("Mouse Y");

        transform.position = new Vector3(pos.x, pos.y, 0);
    }
}
