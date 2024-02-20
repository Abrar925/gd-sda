using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float m_speed;

    private Rigidbody m_rigidbody;


    // Start is called before the first frame update
    void Start()
    {
        m_rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        bool moving = false;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            m_rigidbody.velocity = Vector3.forward * m_speed; // new vector3(0, 0, 1)
            moving = true;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            m_rigidbody.velocity = -Vector3.forward * m_speed;
            moving = true;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            m_rigidbody.velocity = Vector3.left * m_speed;
            moving = true;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            m_rigidbody.velocity = Vector3.right * m_speed;
            moving = true;
        }

        if (!moving)
        {
            m_rigidbody.velocity = Vector3.zero;
        }
    }
}
