using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShootingController : MonoBehaviour
{
    [SerializeField] private GameObject m_bullet;
    [SerializeField] private EnemyData m_data;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Shoot", 0.0f, m_data.ShootingRate);
    }

    private void Shoot()
    {
        GameObject newBullet = Instantiate(m_bullet, transform.position + Vector3.up, Quaternion.identity);
        newBullet.GetComponent<BulletController>().Init(m_data.BulletSpeed);
    }
}
