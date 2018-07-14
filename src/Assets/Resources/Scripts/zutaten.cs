using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zutaten : MonoBehaviour {

    public GameObject infobox;
    public GameObject tequila;
    public GameObject tripple_sec;
    public GameObject limettensaft;
    public GameObject zuckersirup;
    public GameObject pfeile_links;
    public GameObject pfeile_rechts;

	// Use this for initialization
	void Start () {
        infobox.SetActive(false);
        tequila.SetActive(false);
        tripple_sec.SetActive(false);
        zuckersirup.SetActive(false);
        limettensaft.SetActive(false);
        pfeile_links.SetActive(false);
        pfeile_rechts.SetActive(false);

    }

    void OnMouseDown()
    {
        infobox.SetActive(true);
        tequila.SetActive(true);
        tripple_sec.SetActive(true);
        pfeile_links.SetActive(true);
        pfeile_rechts.SetActive(true);
    }
}
