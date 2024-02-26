using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shot : MonoBehaviour
{
    [SerializeField] private GameObject m_bullet;
    [SerializeField] private float m_shootingRate;
    [SerializeField] private float m_bulletSpeed;

    private PauseController m_pauseController;

    // Start is called before the first frame update
    void Start()
    {
        m_pauseController = FindObjectOfType<PauseController>();
    }

    // Update is called once per frame

    void Update()
    {
        if (!m_pauseController.IsPaused)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                InvokeRepeating("Shoot", 0.0f, m_shootingRate);
            }

            if (Input.GetKeyUp(KeyCode.Space))
            {
                CancelInvoke();
            }
        }
    }

    private void Shoot()
    {
        GameObject newBullet = Instantiate(m_bullet, GetComponent<Transform>().position, Quaternion.identity);
        newBullet.GetComponent<BulletController>().Init(m_bulletSpeed, false, false);
    }

}



