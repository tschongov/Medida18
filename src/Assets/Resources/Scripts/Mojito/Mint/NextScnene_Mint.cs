using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScnene_Mint : MonoBehaviour {

    public GameObject part1;
    public GameObject part2;
    public GameObject part3;
    public GameObject part4;
    public GameObject Hook;

	// Use this for initialization
	void Start () {
        Hook.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        if (!part1.activeSelf & !part2.activeSelf & !part3.activeSelf & !part4.activeSelf)
        {
            Hook.SetActive(true);
            StartCoroutine(WaitAndLoadScene());
        }
    }

    IEnumerator WaitAndLoadScene()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Mojito.Add_Rum");
    }


}
