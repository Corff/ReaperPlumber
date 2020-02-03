using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class freezeHit : MonoBehaviour
{
    public BoxCollider2D bc;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(waitForSeconds(.5f));
        //bc.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if(other.tag == "Player")
        {
            other.GetComponent<Player>().health -= 0.5f;
        }
    }



    IEnumerator waitForSeconds(float a)
    {
        yield return new WaitForSeconds(a);
        gameObject.GetComponent<SpriteRenderer>().color = new Color(0, 0, 255, 0.51f);
        bc.enabled = true;
    }

}
