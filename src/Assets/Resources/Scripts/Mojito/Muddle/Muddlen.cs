using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muddlen : MonoBehaviour
{
    public float speed = 20f;
    
    Rigidbody2D rig;

    // Use this for initialization
    void Start()
    {
       
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Fire1");
        float vertical = Input.GetAxis("Mouse Y");
        Vector2 move = new Vector2(horizontal, vertical) * speed * Time.deltaTime;
        rig.MovePosition(rig.position + move);

    }
}

