using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class on_hover : MonoBehaviour {

			private Text label;

			public void Start(){
				label = GameObject.Find("Chapter").GetComponent<Text>();
			}

	    public void pointer_enter(String text)
	    {
	        label.text = text;
	    }

	    public void pointer_exit()
	    {
	        label.text = "";
	    }
}
