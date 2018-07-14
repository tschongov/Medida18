using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class open : MonoBehaviour {

    public GameObject infobox;
    public GameObject lime;
    public GameObject salt;
    public GameObject salt2;

	// Use this for initialization
	void Start () {

        infobox.SetActive(false);
        lime.SetActive(false);
        salt.SetActive(false);
        salt2.SetActive(false);
    }

    void OnMouseDown()
    {
        infobox.SetActive(true);
        lime.SetActive(true);
        salt.SetActive(true);
    }

    
}
