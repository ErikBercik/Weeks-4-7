using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteRendererScript : MonoBehaviour
{

public SpriteRenderer spriteRenderer;


    // Start is called before the first frame update
    void Start()
    {
    //This is like in the readings, just want to change it randomly
    spriteRenderer.color = Random.ColorHSV();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
