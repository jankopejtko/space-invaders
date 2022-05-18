using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getHit : MonoBehaviour
{
    public GameObject enemy;
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Bullet")
        {
            Destroy(col.gameObject);
            getAllChildren.childrenList.RemoveAt(enemy.transform.GetSiblingIndex());
            Destroy(enemy);
            skoreCounter.addScore(50);
        }
    }
}