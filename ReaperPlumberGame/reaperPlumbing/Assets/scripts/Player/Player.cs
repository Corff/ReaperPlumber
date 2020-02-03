using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float health = 1;
    [SerializeField] private health healthBar;
    float lastHealth;

    void Start()
    {
        lastHealth = health;
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.setSize((health/8));

        if (health < 1)
        {
            Destroy(gameObject);
            SceneManager.LoadScene(6);
        }

        if(health < lastHealth)
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.red;
            StartCoroutine(flashRed());
        }
        lastHealth = health;

    }

    IEnumerator flashRed()
    {
        yield return new WaitForSeconds(.25f);
        gameObject.GetComponent<SpriteRenderer>().color = Color.white;
    }

}
