using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class lifeCounter : MonoBehaviour
{
    public static int numberOfLife = 3;
    public RawImage[] lifes;
    private void Update()
    {
        deleteGUIlife(lifes);
    }
    private static void deleteGUIlife(RawImage[] imageList) 
    {
        for (int i = 0; i < imageList.Length; i++) 
        {
            if(i < numberOfLife) 
            {
                imageList[i].gameObject.SetActive(true);
            }
            else 
            {
                imageList[i].gameObject.SetActive(false);
            }
        }
    }
    public static void chackDead()
    {
        if(numberOfLife <= 0) 
        {
            SceneManager.LoadScene("end");
        }
    }
}