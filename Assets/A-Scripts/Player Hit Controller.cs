using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHitController : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "EnemysBullet")
        {
            Debug.Log("Player was hit by the enemy bullet!");
        }
    }
}
