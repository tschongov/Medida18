using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class messbecher2 : MonoBehaviour {

    public GameObject infobox;
    public GameObject scala;
    public GameObject mess;
    public GameObject scala20;
    public GameObject becher;

    void OnMouseDown()
    {
        infobox.SetActive(false);
        scala.SetActive(false);
        mess.SetActive(false);
        scala20.SetActive(false);
        becher.SetActive(true);
    }
}

