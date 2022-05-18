using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveToPlayer : MonoBehaviour
{
    public GameObject enemy;
    private bool smer = true;
    private bool enable = false;
    private bool moveHorizontaly = true;
    private float movementSpeed = 1f;
    private void Start()
    {
        Camera cam = Camera.main;
        float height = 2f * cam.orthographicSize;
        float width = height * cam.aspect;
        while (enemy.GetComponent<Rigidbody2D>().transform.transform.position.x <= -width / 2 + 3f)
        {
            enemy.GetComponent<Rigidbody2D>().transform.transform.position = new Vector2(enemy.GetComponent<Rigidbody2D>().transform.transform.position.x + 1 * movementSpeed * Time.deltaTime, enemy.GetComponent<Rigidbody2D>().transform.transform.position.y);
        }
        enable = true;
    }
    private void move() 
    {
        if (moveHorizontaly) 
        {
            if (smer)
            {
                enemy.GetComponent<Rigidbody2D>().transform.transform.position = new Vector2(enemy.GetComponent<Rigidbody2D>().transform.transform.position.x + 1 * movementSpeed * Time.deltaTime, enemy.GetComponent<Rigidbody2D>().transform.transform.position.y); 
            }
            else if(!smer)
            {
                enemy.GetComponent<Rigidbody2D>().transform.transform.position = new Vector2(enemy.GetComponent<Rigidbody2D>().transform.transform.position.x - 1 * movementSpeed * Time.deltaTime, enemy.GetComponent<Rigidbody2D>().transform.transform.position.y);
            }
        }
        checkCollision();
    }
    private void checkCollision()
    {
        Camera cam = Camera.main;
        float height = 2f * cam.orthographicSize;
        float width = height * cam.aspect;
        if (enemy.GetComponent<Rigidbody2D>().transform.transform.position.x <= -width/2 + 3f || enemy.GetComponent<Rigidbody2D>().transform.transform.position.x >= width/2 - 3f) 
        {
            moveHorizontaly = false;
            enemy.GetComponent<Rigidbody2D>().transform.transform.position = new Vector2(enemy.GetComponent<Rigidbody2D>().transform.transform.position.x, enemy.GetComponent<Rigidbody2D>().transform.transform.position.y - 1);
            smer = !smer;
            moveHorizontaly = true;
        }
    }
    void Update()
    {
        if (enable) 
        {
            move();
        }
    }
}