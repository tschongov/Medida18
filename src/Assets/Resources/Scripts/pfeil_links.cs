using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pfeil_links : MonoBehaviour {

    public GameObject tequila;
    public GameObject tripple_sec;
    public GameObject zuckersirup;
    public GameObject limettensaft;

    void OnMouseDown()
    {
        tequila.SetActive(true);
        tripple_sec.SetActive(true);
        zuckersirup.SetActive(false);
        limettensaft.SetActive(false);
    }
}
