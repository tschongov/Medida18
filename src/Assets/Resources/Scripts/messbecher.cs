using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class messbecher : MonoBehaviour {

    public GameObject infobox;
    public GameObject scala;
    public GameObject mess;
    public GameObject scala40;
    public GameObject becher;

    void OnMouseDown()
    {
        infobox.SetActive(false);
        scala.SetActive(false);
        mess.SetActive(false);
        scala40.SetActive(false);
        becher.SetActive(true);
    }
}
