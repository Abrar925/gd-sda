using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam : MonoBehaviour
{
    [SerializeField] private float m_speed;
         
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"component started .Speed: {m_speed}"); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
