using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyShoot : MonoBehaviour
{
    public GameObject enemyBullet;
    private float TTL = 2f;
    private float launchVelocity = 500f;
    public float fireRate = Random.Range(2, 10);
    private float nextFire = Random.Range(1, 5);
    void Update()
    {
        if (Time.time > nextFire)
        {
            if (!enemyBullet)
            {
                return;
            }
            nextFire = Time.time + fireRate;
            GameObject bullet = Instantiate(enemyBullet, transform.position, transform.rotation);
            bullet.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -launchVelocity));
            Destroy(bullet, TTL);
        }
        fireRate = Random.Range(2, 10);
    }
}