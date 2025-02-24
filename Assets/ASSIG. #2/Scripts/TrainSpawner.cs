using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrainSpawner : MonoBehaviour
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

    public void SpawnTrain()
    {
        //this spawns the instance
        GameObject newTrain = Instantiate(prefab);
        newTrain.GetComponent<Sprite>();
        //This deletes it according to my slider timing
        Destroy(newTrain, timeLeft);
    }

    public void TimeLeftSLiderValue()
    {
        //this lets me set my despawn time
        timeLeft = TimeLeftSlider.value;
    }

    //I don't have it in me to do the speeds and colour but this is where it would go like the slider above
}
