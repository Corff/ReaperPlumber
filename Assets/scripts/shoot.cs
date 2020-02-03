using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public bool turnToShoot = false;
    public float cooldown = 1.6f;
    AudioSource shootSound;

    private void Start()
    {
        shootSound = GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            if (turnToShoot)
            {
                Shoot();
                turnToShoot = false;
            }
            else
            {
                turnToShoot = true;
            }
        }
    }

    void Shoot()
    {
        shootSound.Play(0);
        for (int i = 1; i < 8; i++)
        {
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            var randx = Random.Range(-30, 30);
            var randy = Random.Range(-30, 30);
            bullet.transform.Rotate(randx, randy, 0);
        }
    }
}
