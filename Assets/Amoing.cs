using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Amoing : MonoBehaviour
{
    Vector3 forwaed = new Vector3(0, 3, 0.1f);
    Vector3 backwaed = new Vector3(0, 0, -1.0f);
    Vector3 right = new Vector3(2.0f, 0);
    Vector3 left = new Vector3(-1.0f, 0);


    public Rigidbody FristRigidBody;
    public void Awake()
    {
        
            FristRigidBody = GetComponent<Rigidbody>();
        }

        // Start is called before the first frame update
        void Start()
        {
             GetComponent<Rigidbody>();
        }


        // Update is called once per frame
        void Update()

        {
            if (Input.GetKey(KeyCode.UpArrow))
                FristRigidBody.velocity = Vector3.forward;
        
            if (Input.GetKey(KeyCode.DownArrow))
                FristRigidBody.velocity = Vector3.back;
     
            if (Input.GetKey(KeyCode.RightArrow))
                FristRigidBody.velocity = Vector3.right;
       
            if (Input.GetKey(KeyCode.LeftArrow))
                FristRigidBody.velocity = Vector3.left;
        }

    
}






