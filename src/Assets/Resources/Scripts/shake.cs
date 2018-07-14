using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shake : MonoBehaviour {

    void OnMouseDrag()
    {

        Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = (pos);

    }
    
 }
