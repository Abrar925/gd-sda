using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureScroll : MonoBehaviour
{
    public float scrollspeed;

    public bool scroll = true;

    Material BackgroundMaterial;

    private void Awake()
    {
        BackgroundMaterial = GetComponent<Renderer>().material;
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (scroll)
        {
            Vector2 offset = new Vector2(scrollspeed * Time.time, 0);

            BackgroundMaterial.mainTextureOffset = offset;
        }
    }
}
