using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Overwatch_Stamp : MonoBehaviour {


    public GameObject popup;
    public GameObject Hook;
    public GameObject dialogue;
	// Use this for initialization
	void Start () {
        Hook.SetActive(false);
        popup.SetActive(false);
        
	}
	
	// Update is called once per frame
	void Update () {
		if (!dialogue.activeSelf)
        {
            popup.SetActive(true);
        }
	}
}
