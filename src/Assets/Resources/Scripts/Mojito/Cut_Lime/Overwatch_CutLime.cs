using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Overwatch_CutLime : MonoBehaviour {


    public GameObject Lime;
    public GameObject Board;
    public GameObject dBox;
    public GameObject Hook;
    
	// Use this for initialization
	void Start () {
        Hook.SetActive(false);
        Lime.SetActive(false);
        Board.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        if (!dBox.activeSelf)
        {
            Lime.SetActive(true);
            Board.SetActive(true);
        }
	}
}
