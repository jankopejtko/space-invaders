using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class outOfBound : MonoBehaviour
{
    public GameObject rocket;
    public static bool leftAppCollide = false;
    public static bool rightAppCollide = false;

    void Update()
    {
        Camera cam = Camera.main;
        float height = 2f * cam.orthographicSize;
        float width = height * cam.aspect;
        if(rocket.transform.transform.position.x <= -width/2 + 0.5f)
        {
            leftAppCollide = true;
        }
        else if(rocket.transform.position.x >= width/2 - 0.5f) 
        {
            rightAppCollide = true;
        }
        else 
        {
            leftAppCollide = false;
            rightAppCollide = false;
        }
    }
}