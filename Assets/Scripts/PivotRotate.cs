using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PivotRotate : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 rot = transform.eulerAngles;
            rot.z += -30;
            transform.eulerAngles = rot;
        }

    }
}
