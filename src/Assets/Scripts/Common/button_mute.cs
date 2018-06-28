using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class button_mute : MonoBehaviour {

	Sprite mute;
	Sprite muted;

	public void Start(){
		mute = Resources.Load<Sprite>("Graphics/mute");
		muted = Resources.Load<Sprite>("Graphics/muted");
	}

	public void mute_game(Button button) {

		AudioListener.pause = !AudioListener.pause;

		if (AudioListener.pause)
			button.GetComponent<Image>().sprite = muted;
		else
			button.GetComponent<Image>().sprite = mute;
	}

}
