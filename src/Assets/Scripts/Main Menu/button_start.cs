using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button_start : MonoBehaviour {

	public void start_game() {
		SceneManager.LoadScene("Introvideo");
	}
}
