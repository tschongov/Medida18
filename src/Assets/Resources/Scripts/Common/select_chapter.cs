using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class select_chapter : MonoBehaviour {

	public void change_chapter(String chapter){
		SceneManager.LoadScene(chapter);
	}

}
