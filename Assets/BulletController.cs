using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    [SerializeField] private float m_speed;
    [SerializeField] private float m_lifetime;
    [SerializeField] private string m_ignoredTag;

    private Rigidbody m_rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, m_lifetime);
        m_rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //transform.position += Vector3.forward * m_speed * Time.deltaTime;
        m_rigidbody.velocity = Vector3.forward * m_speed;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != m_ignoredTag)
        {
            Destroy(gameObject);
        }

    }
}
