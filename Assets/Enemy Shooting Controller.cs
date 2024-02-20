using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShootingController : MonoBehaviour
{
    [SerializeField] private GameObject m_bullet;
    [SerializeField] private float m_shootingRate;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Shoot", 0.0f, m_shootingRate);
    }

    private void Shoot()
    {
        Instantiate(m_bullet, transform.position + Vector3.up, Quaternion.identity);
    }
}
