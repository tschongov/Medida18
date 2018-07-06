using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load_NextScene : MonoBehaviour {
    public GameObject Lime;
    public String chapter;
	// Use this for initialization
	void OnMouseDown () {
           
            SceneManager.LoadScene(chapter);
     
    }

    // Update is called once per frame
    void Update () {
		
          
 
	}
}
