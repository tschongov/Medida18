using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drag_Bottle : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDrag()
    {
        Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.Rotate(135, 0, 0);
        transform.position = (pos);
     
    }
}
