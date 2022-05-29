using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chackBottom : MonoBehaviour
{
    public GameObject wave;
    public static float height;
    private void Start()
    {
        Camera cam = Camera.main;
        height = 2f * cam.orthographicSize;
    }
    private void Update()
    {
        if (wave.transform.transform.position.y - 2f <= -height /2)
        {
            Destroy(wave);
            lifeCounter.numberOfLife--;
            spawnNewWave.enableSpawnWave();
            Debug.Log("wave bottom collison");
        }
    }
}
