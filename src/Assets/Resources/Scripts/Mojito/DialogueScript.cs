using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueScript : MonoBehaviour {

    public GameObject dBox;
    public GameObject dtext;
    public GameObject avatar;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (dBox.activeSelf && Input.GetMouseButtonDown(0))
        {
            dBox.SetActive(false);
            avatar.SetActive(false);
        }
	}
}
