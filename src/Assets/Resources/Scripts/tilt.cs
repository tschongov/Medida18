using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tilt : MonoBehaviour {

    Quaternion target;
    public float speed = 30;

    void Update()
    {
        transform.rotation = Quaternion.RotateTowards(transform.rotation, target, 90);
    }
}
