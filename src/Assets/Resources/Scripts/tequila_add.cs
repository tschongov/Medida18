using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tequila_add : MonoBehaviour {

    public GameObject infobox;
    public GameObject scala;
    public GameObject mess;
    public GameObject scala40;
    public GameObject inhalt;
    public GameObject becher;

    void Start()
    {
        infobox.SetActive(false);
        scala.SetActive(false);
        mess.SetActive(false);
        scala40.SetActive(false);
        inhalt.SetActive(false);
        becher.SetActive(false);
    }

    void OnMouseDown()
    {
        infobox.SetActive(true);
        scala.SetActive(true);
        mess.SetActive(true);
        scala40.SetActive(true);
    }
}
