using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneLoader : MonoBehaviour
{
    public static void loadScene(string sceneIndex) 
    {
        SceneManager.LoadScene(sceneIndex);
    }
    public static void exitApp() 
    {
        Application.Quit();
    }
}