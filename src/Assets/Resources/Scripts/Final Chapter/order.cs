using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class order : MonoBehaviour {

	GameObject selected_object = null;
	GameObject step1, step2, step3, step4, step5, text;
	bool completed = false;

	// Use this for initialization
	void Start () {
		text = GameObject.Find("text");
		step1 = GameObject.Find("step1");
		step2 = GameObject.Find("step2");
		step3 = GameObject.Find("step3");
		step4 = GameObject.Find("step4");
		step5 = GameObject.Find("step5");
	}

	public void on_click(GameObject obj){
		selected_object = obj;
	}

	public void on_leave(){
		selected_object = null;
	}

	public void advance(){
		if (completed)
			SceneManager.LoadScene("Quiz");
	}

	// Update is called once per frame
	void Update () {
		if (selected_object != null && !completed)
			selected_object.GetComponent<Transform>().position = Input.mousePosition;

		if (!completed && Input.GetMouseButtonUp(0)){
			if (step1.GetComponent<Transform>().position.y > step2.GetComponent<Transform>().position.y && step2.GetComponent<Transform>().position.y > step3.GetComponent<Transform>().position.y && step3.GetComponent<Transform>().position.y > step4.GetComponent<Transform>().position.y && step4.GetComponent<Transform>().position.y > step5.GetComponent<Transform>().position.y){
				text.GetComponent<Text>().text = "Wunderbar, das ist der richtige Ablauf um einen Mojito zu erstellen!";
				completed = true;
			}
		}
	}
}
