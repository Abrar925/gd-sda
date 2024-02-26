using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    [SerializeField] private float m_lifetime;
    [SerializeField] private string m_ignoredTag;

    private float m_speed;
    private Rigidbody m_rigidbody;
    private PlayerMovementController m_player;
    private Quaternion m_quat;
    private bool m_followPlayer;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, m_lifetime);
        m_rigidbody = GetComponent<Rigidbody>();
    }

    public void Init(float speed, bool lookAtPlayer, bool followPlayer)
    {
        m_speed = speed;

        if (lookAtPlayer)
        {
            m_player = FindAnyObjectByType<PlayerMovementController>();
            m_quat = Quaternion.LookRotation(m_player.transform.position - transform.position);
            m_followPlayer = followPlayer;

        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(m_followPlayer)
        {
            m_quat = Quaternion.LookRotation(m_player.transform.position - transform.position);
        }
        //transform.position += Vector3.forward * m_speed * Time.deltaTime;
        m_rigidbody.velocity = m_quat * Vector3.forward * m_speed;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != m_ignoredTag)
        {
            Destroy(gameObject);
        }

    }
}
