using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
    public int speed;
    Rigidbody2D rig;
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }


    void OnMouseDrag()
    {
        //float horizontal = Input.GetAxis("Fire1");
        float vertical = Input.GetAxis("Mouse Y");
        Vector2 move = new Vector2(0, vertical) * speed * Time.deltaTime;
        rig.MovePosition(rig.position + move);
    }
}





