using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
Slider slider;
public float timeLeftTimer;
public Slider TimeLeftSlider;

    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();
      
    }

    // Update is called once per frame
    void Update()
    {
        
        //This is just for visuals at this point, it's not pretty but it functions. 
        //It took so much effort last time to clean it up right, I'm sorry
        timeLeftTimer += Time.deltaTime;
        //The higher the value, slower the clock moves to indicate slider value
        slider.value = (timeLeftTimer % TimeLeftSlider.value);
    }

 
}
