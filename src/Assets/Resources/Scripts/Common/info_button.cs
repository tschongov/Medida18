using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class info_button : MonoBehaviour {

	GameObject infobox;
	GameObject blackground;
	GameObject left;
	GameObject right;
	GameObject close;
	GameObject start;
	GameObject info;
	int page = 0;

	// Use this for initialization
	void Start () {
		infobox = GameObject.Find("infobook");
		blackground = GameObject.Find("blackground");
		left = GameObject.Find("left");
		right = GameObject.Find("right");
		close = GameObject.Find("close");
		start = GameObject.Find("start");
		info = GameObject.Find("info");
		on_close();
	}

	public void on_open(){
		infobox.SetActive(true);
		blackground.SetActive(true);
		left.SetActive(true);
		right.SetActive(true);
		close.SetActive(true);
		start.SetActive(false);
		info.SetActive(false);
	}

	public void on_close(){
		infobox.SetActive(false);
		blackground.SetActive(false);
		left.SetActive(false);
		right.SetActive(false);
		close.SetActive(false);
		start.SetActive(true);
		info.SetActive(true);
	}

	public void page_left(){
		page -=1;

		right.SetActive(true);
	}

	public void page_right(){
		page +=1;

		left.SetActive(true);
	}

	// Update is called once per frame
	void Update () {
		if (page < 1){
			page = 0;
			left.SetActive(false);
		}

		if (page > 2){
			page = 2;
			right.SetActive(false);
		}
	}
}
