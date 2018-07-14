using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cut_full : MonoBehaviour {

    
    public GameObject Lime;
    public GameObject Lime2;


	// Use this for initialization
	void Start ()
    {
        Lime2.SetActive(false);
        
	}
	
	// Update is called once per frame
	void Update () {
       

	}

    void OnMouseDown()
    {
        Lime.SetActive(false);
        Lime2.SetActive(true);
    }
}
