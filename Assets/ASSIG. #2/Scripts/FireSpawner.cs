using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FireSpawner : MonoBehaviour
{
public float timeLeft = 5f;
public Slider TimeLeftSlider;
public GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    // This is all the same as the train script.

    public void SpawnFire()
    {
        //this spawns the instance
        GameObject newFire = Instantiate(prefab);
        newFire.GetComponent<Sprite>();
        //This deletes it according to my slider timing
        Destroy(newFire, timeLeft);
    }

    public void TimeLeftSLiderValue()
    {
        //this lets me set my despawn time
        timeLeft = TimeLeftSlider.value;
    }
}
