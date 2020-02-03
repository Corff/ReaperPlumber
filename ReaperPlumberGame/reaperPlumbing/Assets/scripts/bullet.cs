using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public GameObject hitEffect;
    public float Force = 500f;
    public float lifetime = 0.5f;
    public Rigidbody2D rb;

    private void Start()
    {
        Destroy(gameObject, lifetime);
        rb.AddForce(gameObject.transform.up * Force /*** Time.deltaTime*/, ForceMode2D.Impulse);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Instantiate(hitEffect, transform.position, Quaternion.identity);
        //Destroy(hitEffect, 2f);

        if (collision.CompareTag("Wall"))
        {
            collision.GetComponent<Wall>().health = collision.GetComponent<Wall>().health - 1;
            Destroy(gameObject);

        } 
        else if (collision.CompareTag("Enemy"))
        {
            collision.GetComponent<Enemy>().health = collision.GetComponent<Enemy>().health - 1;
            Destroy(gameObject);
            
        }
        else if (collision.CompareTag("Boss"))
        {
            collision.GetComponent<bossHealth>().health = collision.GetComponent<bossHealth>().health - 1;
            Destroy(gameObject);
        }
    }
}
