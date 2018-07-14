using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load_NextScene : MonoBehaviour {
    public GameObject Hook;
    public String chapter;


	// Use this for initialization
	void OnMouseDown () {

        Hook.SetActive(true);
        StartCoroutine(WaitAndLoadScene());

    }

    IEnumerator WaitAndLoadScene()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Mojito.Stamp_Lime");
    }
}


		
       