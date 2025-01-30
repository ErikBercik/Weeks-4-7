using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    GameObject needle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

       if( Input.GetMouseButtonDown(0))
        {

            needle = Instantiate(prefab);

        }


    }
}
