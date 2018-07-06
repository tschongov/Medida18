using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ifPicked_Checker : MonoBehaviour
{

    Vector3 lastPos;
    public Transform obj; // drag the object to monitor here
    public GameObject part;
    float threshold = 2.0f; // minimum displacement to recognize a 

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
            Debug.Log("gezupft");
            part.SetActive(false);
        }
        else
        if (offset.x < -threshold)
        {
            lastPos = obj.position; // update lastPos
                                    // code to execute when X is getting smaller 
            Debug.Log("gezupft");
            part.SetActive(false);
        }
    }
}