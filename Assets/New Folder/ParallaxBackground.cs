using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxBackground : MonoBehaviour
{
    private GameObject cam;
    // declare 
    private SpriteRenderer spriteRenderer;
    [SerializeField] private float parallaxEffect;

    private float length;
    private float xPosition;

    void Start()
    {

        // check if spriteRenderer exists, if not attach it
        spriteRenderer = GetComponent<SpriteRenderer>();

        if (spriteRenderer == null)
        {
            Debug.LogWarning("SpriteRenderer not found on " + gameObject.name + ". Adding one.");
            spriteRenderer = gameObject.AddComponent<SpriteRenderer>();
        }
        cam = GameObject.Find("Main Camera");
        length = GetComponent<SpriteRenderer>().bounds.size.x;
        xPosition = transform.position.x;


    }


    void Update()
    {
        float distanceMoved = cam.transform.position.x * (1 - parallaxEffect);
        float distanceToMove = cam.transform.position.x * parallaxEffect;

        transform.position = new Vector3(xPosition + distanceToMove, transform.position.y);

        if (distanceMoved > xPosition + length)
        {
            xPosition = xPosition + length;
        }
    }
}