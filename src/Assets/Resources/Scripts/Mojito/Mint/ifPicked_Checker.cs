using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ifPicked_Checker : MonoBehaviour
{

    Vector3 lastPos;
    Transform obj; // drag the object to monitor here
    float threshold = 0.0f; // minimum displacement to recognize a 

    void Start()
    {
        lastPos = obj.position;
    }

    void Update()
    {
        Vector3 offset = obj.position - lastPos;
        if (offset.x > threshold)
        {
            lastPos = obj.position; // update lastPos
                                    // code to execute when X is getting bigger
        }
        else
        if (offset.x < -threshold)
        {
            lastPos = obj.position; // update lastPos
                                    // code to execute when X is getting smaller 
        }
    }
}