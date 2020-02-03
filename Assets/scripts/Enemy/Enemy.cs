using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update


    private Vector2 movement = new Vector2(0, 0);
    Vector2 speedReduction = new Vector2(0.2f, 0.2f);

    public GameObject particles;

    public GameObject PlayerObject;
    public Rigidbody2D rb;
    public float moveSpeed = 2f;
    public int health = 12;
    float IDKnockback = 1.3f;
    int EnemyID;
    int pushCount;
    int Damage = 1;
    Vector2 knockback = new Vector2();

    void Start()
    {
        PlayerObject = GameObject.FindGameObjectWithTag("Player");
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            //collision.GetComponent<SpriteRenderer>().color = Color.red;
            //StartCoroutine(changeColor(collision));
            knockback = new Vector2(movement.x * -1, movement.y * -1);
            if (EnemyID == 1)
            {
                particles = Instantiate(particles, this.transform.position, this.transform.rotation);
                collision.GetComponent<Player>().health = collision.GetComponent<Player>().health - Damage;
                Destroy(gameObject);
            }
            else
            {
                collision.GetComponent<Player>().health = collision.GetComponent<Player>().health - Damage;
                pushCount = 50;
                rb.MovePosition(rb.position + movement * moveSpeed * speedReduction * Time.fixedDeltaTime);
            }
        }
    }

    public bool validSpeed()
    {
        if (movement.y > 10 || movement.y < -10 || movement.x > 10 || movement.x < -10) 
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    void Update()
    {
        try
        {
            //get player position, determine how to move
            Vector2 playerPos = PlayerObject.transform.position;
            Vector2 thisPos = rb.position;
            Vector2 difference = thisPos - playerPos;

            //normal movement
            if (validSpeed())
            {
                if (difference.x > 0)
                {
                    movement.x = movement.x - 1;
                    if (difference.y > 0)
                    {
                        movement.y = movement.y - 1;
                    }
                    else if (difference.y < 0)
                    {
                        movement.y = movement.y + 1;
                    }
                }
                else if (difference.x < 0)
                {
                    movement.x = movement.x + 1;
                    if (difference.y > 0)
                    {
                        movement.y = movement.y - 1;
                    }
                    else if (difference.y < 0)
                    {
                        movement.y = movement.y + 1f;
                    }

                }
                else if (difference.x == 0)
                {
                    if (difference.y > 0)
                    {
                        movement.y = movement.y + 1;
                    }
                    else if (difference.y < 0)
                    {
                        movement.y = movement.y - 1;
                    }
                }
            } 
            else
            {
                if (pushCount > 0)
                {
                    rb.AddForce(knockback * IDKnockback * pushCount);
                    pushCount = pushCount - 1;
                }
                movement.x = movement.x - (movement.x * 0.1f);
                movement.y = movement.y - (movement.y * 0.1f);
            }
            rb.MovePosition(rb.position + movement * moveSpeed * speedReduction * Time.fixedDeltaTime);
        }
        catch (MissingReferenceException)
        {
        }

        if (health <= 0)
        {
            Destroy(gameObject);
        }

    }

    //IEnumerator changeColor(Collider2D other)
    //{
    //    yield return new WaitForSeconds(0.25f);
    //    other.GetComponent<SpriteRenderer>().color = Color.white;
    //}

}
