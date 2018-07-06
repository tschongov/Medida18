using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScnene_Mint : MonoBehaviour {

    public GameObject part1;
    public GameObject part2;
    public GameObject part3;
    public GameObject part4;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (!part1.activeSelf & !part2.activeSelf & !part3.activeSelf & !part4.activeSelf)
        {
            SceneManager.LoadScene("Mojito_Main");
        }

	}
}
