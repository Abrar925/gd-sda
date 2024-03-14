using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCemera : MonoBehaviour
{
    Transform playerTransform;

    float initialCameraOffset;

    Vector3 cameraRotation;

    private void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        initialCameraOffset = Vector3.Distance(transform.position, playerTransform.position);
        cameraRotation = transform.rotation.eulerAngles;
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");

        if (mouseX != 0)
        {
            cameraRotation.y += mouseX;
           
        }

        transform.eulerAngles = cameraRotation;
        Vector3 cameraLookDirection = Quaternion.Euler(cameraRotation) * Vector3.forward;
        transform.position = - cameraLookDirection *  initialCameraOffset + playerTransform.position;



        void OnEnable()
        {
            Cursor.lockState = CursorLockMode.Locked;
        }


        void OnDisable()
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
