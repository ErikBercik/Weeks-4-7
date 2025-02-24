using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TruckSpawner : MonoBehaviour
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
    //This is all the same as the train

    public void SpawnTruck()
    {
        //this spawns the instance
        GameObject newTruck = Instantiate(prefab);
        newTruck.GetComponent<Sprite>();
        //This deletes it according to my slider timing
        Destroy(newTruck, timeLeft);
    }

    public void TimeLeftSLiderValue()
    {
        //this lets me set my despawn time
        timeLeft = TimeLeftSlider.value;
    }
}
