using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnNewWave : MonoBehaviour
{
    public GameObject wave;
    public static bool enable;
    private Vector2 screenBounds;
    private void Start()
    {
        enable = true;
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        createWave();
    }
    public static void enableSpawnWave()
    {
        enable = true;
    }
    private void createWave()
    {
        if (enable == true) 
        {
            GameObject a = Instantiate(wave) as GameObject;
            a.transform.position = new Vector2(screenBounds.x * - 1/2 - 2f, screenBounds.y - 1f);
        }
        enable = false;
    }
    private void Update()
    {
        createWave();
    }
}