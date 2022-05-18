using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyShoot : MonoBehaviour
{
    public GameObject enemyBullet;
    private float TTL = 2f;
    private float launchVelocity = 500f;
    public float fireRate;
    private float nextFire = 0.0f;
    void Update()
    {
        if (Time.time > nextFire)
        {
            if (!enemyBullet)
            {
                return;
            }
            nextFire = Time.time + fireRate;
            GameObject ball = Instantiate(enemyBullet, transform.position, transform.rotation);
            ball.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -launchVelocity));
            Destroy(ball, TTL);
        }
        fireRate = Random.Range(2, 10);
    }
}