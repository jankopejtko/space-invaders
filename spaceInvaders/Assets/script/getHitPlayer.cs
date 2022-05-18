using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getHitPlayer : MonoBehaviour
{
    public GameObject player;
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "EnemyBullet")
        {
            Destroy(col.gameObject);
            lifeCounter.numberOfLife--;
            lifeCounter.chackDead();
        }
    }
}
