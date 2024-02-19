using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shot : MonoBehaviour
{
    [SerializeField] private GameObject m_bullet;
    [SerializeField] private float m_shootingRate;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame

    void Update()
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

    private void Shoot()
    {
        Instantiate(m_bullet, GetComponent<Transform>().position, Quaternion.identity);
    }

}



