using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cut_full : MonoBehaviour {


    public GameObject Lime;
    public GameObject Lime2;


	// Use this for initialization
	void Start () {
        Lime2.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 lineTracking = Input.mousePosition;
        Debug.Log("x" + lineTracking.x);
        Debug.Log("y" + lineTracking.y);

	}

    void OnMouseDown()
    {
        Lime.SetActive(false);
        Lime2.SetActive(true);
    }
}
