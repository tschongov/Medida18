using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class video_start : MonoBehaviour {

	SpriteRenderer image;
	Sprite[] panels;
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
	int num = 0;

	// Use this for initialization
	void Start () {
		image = GameObject.Find("Panels").GetComponent<SpriteRenderer>();//.GetComponent<Sprite>();
		textfield = GameObject.Find("Text").GetComponent<Text>();
		panels = Resources.LoadAll<Sprite>("Graphics/Introvideo");
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
				num+=1;
				break;

			case 5:
				num+=1;
				break;

			case 7:
				num+=1;
				break;

			case 8:
				num+=1;
				break;

			case 9:
				num+=1;
				break;

			case 12:
				num+=1;
				break;

			case 16:
				num+=1;
				break;
		};

		image.sprite = panels[num];
	}

	// Update is called once per frame
	void Update () {

	}
}
