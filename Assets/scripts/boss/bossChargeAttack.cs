using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossChargeAttack : MonoBehaviour
{
    public Material laser;
    public Vector3 playerPos;
    GameObject player;
    LineRenderer lr;
    bool fired;
    Vector3 lastPos;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        laser.SetColor("_Color", Color.yellow);
        fired = false;
        lr = gameObject.GetComponent<LineRenderer>();
        lr.SetPosition(0, gameObject.transform.localPosition);
        StartCoroutine(waitForSeconds(0.25f));
    }

    // Update is called once per frame
    void Update()
    {
        playerPos = player.GetComponent<Transform>().localPosition;
        if(!fired)
        {
            lr.SetPosition(1, playerPos);
        }
        
    }

    void fire()
    {
        lastPos = playerPos;
        lr.SetPosition(1, lastPos);
        laser.SetColor("_Color", Color.blue);
        StartCoroutine(changeColor());
        fired = true;


    }

    IEnumerator waitForSeconds(float a)
    {
        yield return new WaitForSeconds(a);
        fire();
    }
    IEnumerator changeColor()
    {
        yield return new WaitForSeconds(0.25f);
        laser.SetColor("_Color", Color.red);
        Vector3 cntr = new Vector3(0, 0, 0);
        Debug.DrawRay(cntr, lastPos, Color.green, 99999999999999f);
        RaycastHit2D hit = Physics2D.Raycast(cntr, lastPos,Mathf.Infinity);
        if(hit.collider != null)
        {
            Debug.Log("Hit");
            Debug.Log(hit.collider.tag);
            if(hit.collider.tag == "Player")
            {
                Debug.Log("Hit Player");
                hit.collider.GetComponent<Player>().health -= 1;
            }
        }else
        {
            Debug.Log("Miss");
        }
    }


}
