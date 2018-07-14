using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Away : MonoBehaviour {

    // Use this for initialization

    public GameObject Button;
    public GameObject Dialogue;

	// Update is called once per frame
	void Update () {
		if (Dialogue.activeSelf)
        {
            Button.SetActive(false);
        } else
        {
            Button.SetActive(true);
        }
	}
}
