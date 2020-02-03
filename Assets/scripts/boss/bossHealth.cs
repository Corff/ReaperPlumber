using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class bossHealth : MonoBehaviour
{

    public float health;
    [SerializeField] private bossHealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        health = 1300;
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.setSize(health / 1300);

        if(health <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene(5);
        }

    }
}
