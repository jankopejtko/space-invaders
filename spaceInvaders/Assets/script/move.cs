using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    private float movementSpeed = 5f;
    void moveShip(int horizontalInput) 
    {
        transform.position = transform.position + new Vector3(horizontalInput * movementSpeed * Time.deltaTime,0 , 0);
    }
    void Update()
    {
        if (!outOfBound.leftAppCollide) 
        {
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                moveShip(-1);
            }
        }
        if (!outOfBound.rightAppCollide) 
        {
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                moveShip(1);
            }
        }
    }
}