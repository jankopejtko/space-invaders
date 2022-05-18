using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lifeCounter : MonoBehaviour
{
    public static int numberOfLife = 3;
    public static void chackDead() 
    {
        if(numberOfLife <= 0) 
        {
            SceneManager.LoadScene("end");
        }
    }
}