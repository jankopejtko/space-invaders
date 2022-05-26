using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lifeCounter : MonoBehaviour
{
    private static int numberOfLife = 3;
    private GameObject lifeGUI;
    private List<GameObject> lifeList = new List<GameObject>();
    private void addLifeToList() 
    {
        foreach (Transform child in transform)
        {
            //lifeList.Add(transform);
        }
    }
    void Start()
    {
        
    }
    public void deductLife() 
    {
        deleteGUIlife();
        numberOfLife--;
    }
    private void deleteGUIlife() 
    {
    }
    public static void chackDead()
    {
        if(numberOfLife <= 0) 
        {
            SceneManager.LoadScene("end");
        }
    }
}