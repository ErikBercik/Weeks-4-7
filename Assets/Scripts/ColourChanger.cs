using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColourChanger : MonoBehaviour
{
    public SpriteRenderer brocolor;

    // Start is called before the first frame update
    void Start()
    {

        //Color newColor = new Color(0.8f, 0.1f, 0.8f, 1f);
        
        //UnityEngine.Random.ColorHSV();
    }

    // Update is called once per frame
    public void ColorChangingMagicFunction()
    {
        
        brocolor.color = UnityEngine.Random.ColorHSV();

    }

    public void ColorReturningMagicFunction()
    {

        brocolor.color = new Color(1f, 1f, 1f, 1f);

    }
}
