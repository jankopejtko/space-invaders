using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public GameObject bullet;
    private float TTL = 2f; 
    private float launchVelocity = 700f;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            GameObject ball = Instantiate(bullet, transform.position, transform.rotation);
            ball.GetComponent<Rigidbody2D>().AddForce(new Vector2(0,launchVelocity));
            Destroy(ball, TTL);
        }
    }
}