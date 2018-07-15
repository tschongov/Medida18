using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour {

    public GameObject Hook;

    void Start()
    {
        Hook.SetActive(false);
    }


    public int count = 0;
    void OnCollisionEnter2D()
    {
        if (count >= 10)
            {
            Hook.SetActive(true);
            }
        else
        {
            count++;
        }
    }
}
