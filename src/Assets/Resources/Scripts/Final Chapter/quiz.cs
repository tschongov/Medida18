using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class quiz : MonoBehaviour {

	GameObject question, questionnumber, textboxtext, textbox, sensei, answer1, answer2, answer3, answer4, clicker;

	int pos = 0;
	int answer = 0;
	int qnum = 0;
	bool question_asked = false;

	String[] text = {
		"Es wird nun Zeit, mir einige Fragen richtig zu beantworten.",
		"Wenn du auch nur einen Fehler machst, beginnen wir von Vorne!",
		"Beginnen wir nun mit der ersten Frage:",
		"",
		"Korrekt, wenn weniger Zutaten verwendet werden, nennt man es einen Longdrink.",
		"Weiter geht's:",
		"",
		"Genau!",
		"Jetzt versuchen wir es mal mit etwas schwererem:",
		"",
		"Richtig, ",
		"Hoffentlich kennst du die Antwort zu:",
		"",
		"So wie ich es von meinem Lehrling erwarte! ",
		"Ein echter Barkeeper kennt den Geschmack von allen Getränken",
		"",
		"Ich bin stolz auf dich! ",
		"Wenn du nun diese Frage falsch beantwortest, werde ich extrem enttäuscht:",
		"",
		"Fantastisch, hoffentlich hast du alles nun verstanden!"
	};

	String[] explanation = {
		"Falsch, ein Getränk wird erst als Cocktail eingestuft, wenn es 3 oder Mehr Zutaten enthält.\nVon Vorne!",
		"Falsch,1",
		"Falsch,2",
	};

	String[] questions = {
		"Wann kann man ein Getränk als Cocktail bezeichnen?",
		"Welchen Unterschied gibt es zwischen weißen und braunen Rum?",
		"Welcher Vorteile hat Crushed Ice gegenüber von Cube Ice?",
		"Wie kann man den Geschmack der Minze beim zubereiten intensivieren?",
		"Wie würdest Du einem Freund den Mojito beschreiben?",
		"Was ist ein Longdrink?"
	};

	String[] answers = {

		"A)	Getränk mit min. aus Eis und Flüssigkeit",
		"B)	Getränk mit aus min. 3 Zutaten",
		"C)	Getränk mit min. aus eine bestimmte Menge Spirituose",
		"D)	Getränk mit aus min. 2 Spirituosen",

		"A)	Art der Lagerung",
		"B)	Alkoholgehalt",
		"C)	Rohmaterial ",
		"D)	Geschmack",

		"A)	Es gibt keine Vorteile",
		"B)	Der Kühleffekt wird beschleunigt",
		"C)	Der optische Effekt wird besser erzielt",
		"D)	Das Eis schmilzt schneller als Cube Ice",

		"A)	Minze zerstampfen",
		"B)	Minze mit der Hand zusammenklatschen",
		"C)	Minze trocknen",
		"D)	Minze im heißem Wasser kochen",

		"A)	Fruchtig süß",
		"B)	Erfrischend",
		"C)	Herb",
		"D)	Süßsauer",

		"A)	Getränk mit weniger als 2 Zutaten",
		"B)	Getränk aus alkoholische und nicht alkoholische Komponente",
		"C)	Getränk mit min. 2/3 Anteil an Softdrinks",
		"D)	Getränk das nicht aus einem Shaker gemacht wurde"
	};

	String[] questionnumbers = {
		"Frage #1",
		"Frage #2",
		"Frage #3",
		"Frage #4",
		"Frage #5",
		"Frage #6",
	};


	// Use this for initialization
	void Start () {
		question = GameObject.Find("question");
		questionnumber = GameObject.Find("questionnumber");
		textboxtext = GameObject.Find("text");
		textbox = GameObject.Find("textbox");
		sensei = GameObject.Find("sensei");
		clicker = GameObject.Find("clicker");
		answer1 = GameObject.Find("answer1");
		answer2 = GameObject.Find("answer2");
		answer3 = GameObject.Find("answer3");
		answer4 = GameObject.Find("answer4");

		disable_questions();
	}

	void disable_questions(){
		question.SetActive(false);
		questionnumber.SetActive(false);
		answer1.SetActive(false);
		answer2.SetActive(false);
		answer3.SetActive(false);
		answer4.SetActive(false);
		textboxtext.SetActive(true);
		textbox.SetActive(true);
		sensei.SetActive(true);
		clicker.SetActive(true);
	}

	void disable_text(){
		question.SetActive(true);
		questionnumber.SetActive(true);
		answer1.SetActive(true);
		answer2.SetActive(true);
		answer3.SetActive(true);
		answer4.SetActive(true);
		textboxtext.SetActive(false);
		textbox.SetActive(false);
		sensei.SetActive(false);
		clicker.SetActive(false);
	}


	public void advance(){
		if (pos >=19){
			SceneManager.LoadScene("Main Menu");
			return;
		}

		if (!question_asked){
			pos++;
			textboxtext.GetComponent<Text>().text = text[pos];

			if (pos!= 0 && pos % 3 == 0)
				next();
		}

		else {
			switch(pos){
				case 3:
					check(2);
					break;

				case 6:
					check(3);
					break;

				case 9:
					check(2);
					break;

				case 12:
					check(2);
					break;

				case 15:
					check(1);
					break;

				case(18):
					check(1);
					break;
			}

		}

	}

	void check(int ans){
		if (answer == ans){
			cont();
		}
		else{
			reset();
		}
	}

		void next(){
			disable_text();
			questionnumber.GetComponent<Text>().text = questionnumbers[qnum];
			question.GetComponent<Text>().text = questions[qnum];
			answer1.GetComponent<Text>().text = answers[4*qnum];
			answer2.GetComponent<Text>().text = answers[4*qnum +1];
			answer3.GetComponent<Text>().text = answers[4*qnum +2];
			answer4.GetComponent<Text>().text = answers[4*qnum +3];
			qnum++;
		}

	public void give_answer(int ans){
		answer = ans;
		question_asked = true;
		disable_questions();
		advance();
	}

	void reset(){
		textboxtext.GetComponent<Text>().text = explanation[qnum-1];
		qnum = 0;
		pos = -1;
		question_asked = false;
	}

	void cont(){
		question_asked = false;
		advance();
	}
	// Update is called once per frame
	void Update () {
	}
}
