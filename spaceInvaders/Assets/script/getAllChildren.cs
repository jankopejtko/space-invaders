using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getAllChildren : MonoBehaviour
{
    public GameObject wave; 
    public static ArrayList childrenList = new ArrayList();
    private void waveDead()
    {
        if (childrenList.Count <= 0)
        {
            Destroy(wave.gameObject);
            spawnNewWave.enableSpawnWave();
        }
    }
    void Start()
    {
        Transform[] children = GetComponentsInChildren<Transform>();
        foreach (Transform child in transform)
        {
            childrenList.Add(child);
        }
        waveDead();
    }
    void Update()
    {
        waveDead();
    }
}