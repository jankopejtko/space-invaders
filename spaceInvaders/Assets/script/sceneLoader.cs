using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneLoader : MonoBehaviour
{
    public void loadScene(string sceneIndex) 
    {
        SceneManager.LoadScene(sceneIndex);
    }
}