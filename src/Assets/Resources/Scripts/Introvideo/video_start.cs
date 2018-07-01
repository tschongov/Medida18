using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class video_start : MonoBehaviour {

	GameObject image;
	Text textfield;
	String[] text = {
		"Ich hörte, es soll irgendwo auf der Welt einen Tempel geben, \nwo ein alter Meister nur den Würdigen das perfekte Cocktailmixen beibringt.",
		"Mein Ziel ist es, um die Welt zu reisen, und ihn zu finden.",

		"Ich suche schon seit monaten.",
		"... jedoch vergebens.",
		"Niemand scheint zu wissen, wo er sich befindet.",

		"Oh, sieh mal einer an. \nIch bin irgendwo im nirgendwo gelandet.",
		"Selbst die Bewohner dieser Stadt haben nichts Über die Legende gehört.",

		"Ich habe absolut keine Ahnung mehr, wo ich mich befinde. \nEs wäre wohl eine gute Idee, jemanden in dieser Bar nach dem Weg zu fragen.",

		"Es kann wohl nicht schaden mir zuerst einen Drink zu bestellen, \nDie Wüste macht einen wirklich durstig.",

		"Vielleicht sollte ich meinen Traum aufgeben. \nAnscheinend bin ich nicht würdig genug, diesen Tempel zu finden.",
		"...",
		"\n         ...",

		"D-Das ist ja der Wahnsinn!",
		"Noch nie habe ich einen so leckeren Cocktail getrunken, wie ist das möglich?!",
		"Dieser Cocktail kann nur von einem Großmeister der Mixkunst stammen.",
		"Es besteht kein Zweifel, diese Bar hier muss der legendäre Tempel sein!",

		"Auf einmal verwandelt sich der Barkeeper in einen sehr alten Mann.",
		"\"Ah-hah-ha, willkommen mein neuer Lehrling!\" ",
		"Und so beginnt meine Lehre..."
	};
	int pos = 0;

	// Use this for initialization
	void Start () {
		image = GameObject.Find("Panels");//.GetComponent<Sprite>();
		textfield = GameObject.Find("Text").GetComponent<Text>();
	}

	public void on_click(String chapter){

		if (pos >= text.Length - 1){
			SceneManager.LoadScene(chapter);
			return;
		}

		pos += 1;
		textfield.text = text[pos];

		switch(pos){
			case 3:
				image.transform.position = new Vector2(-8.8f, -18);
				break;


			case 5:
				image.transform.position = new Vector2(8, -6);
				break;

			case 7:
				image.transform.position = new Vector2(-8.8f, -6);
				break;

			case 8:
				image.transform.position = new Vector2(8, 6);
				break;

			case 9:
				image.transform.position = new Vector2(-8.8f, 6);
				break;

			case 12:
				image.transform.position = new Vector2(8, 18);
				break;

			case 16:
				image.transform.position = new Vector2(-8.8f, 18);
				break;
		};
	}

	// Update is called once per frame
	void Update () {

	}
}
