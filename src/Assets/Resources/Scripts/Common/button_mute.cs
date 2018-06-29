using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class button_mute : MonoBehaviour {

	Sprite mute;
	Sprite muted;
	Button button;

	public void Start(){
		mute = Resources.Load<Sprite>("Graphics/mute");
		muted = Resources.Load<Sprite>("Graphics/muted");

		button = GameObject.Find("Mute").GetComponent<Button>();
	}

	public void mute_game(Button button) {

		AudioListener.pause = !AudioListener.pause;


	}

	public void Update(){

		if (AudioListener.pause)
			button.GetComponent<Image>().sprite = muted;
		else
			button.GetComponent<Image>().sprite = mute;
	}

}
