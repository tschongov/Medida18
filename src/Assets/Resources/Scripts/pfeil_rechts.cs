using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pfeil_rechts : MonoBehaviour {

    public GameObject tequila;
    public GameObject tripple_sec;
    public GameObject zuckersirup;
    public GameObject limettensaft;

    void OnMouseDown()
    {
        tequila.SetActive(false);
        tripple_sec.SetActive(false);
        zuckersirup.SetActive(true);
        limettensaft.SetActive(true);
    }
}
