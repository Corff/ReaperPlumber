using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    Rigidbody2D rb;

    public GameObject body;

    public Vector2 offset;

    Vector2 movement;

    public GameObject reticle;

   public Camera cam;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
       movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

       //mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }

    private void FixedUpdate()
    {

        rb.MovePosition(body.GetComponent<Rigidbody2D>().position + offset);

        //  get vector that points from player to mouse pos
        Vector2 lookDir = new Vector2(reticle.transform.position.x, reticle.transform.position.y) - rb.position;

        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg + 90f;
        rb.rotation = angle;
    }
}
