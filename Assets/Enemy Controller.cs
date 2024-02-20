using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private ScoreCounter m_scoreCounter;

    // Start is called before the first frame update
    void Start()
    {
        m_scoreCounter = FindObjectOfType<ScoreCounter>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "PlayerBullet")
        {
            m_scoreCounter.IncreaseCounter();
            Destroy(gameObject);
        }

    }
}
