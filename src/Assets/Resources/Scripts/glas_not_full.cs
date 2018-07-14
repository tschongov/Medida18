using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class glas_not_full : MonoBehaviour {

    public GameObject inhalt_glas;
    public GameObject inhalt_shaker;

	void Start () {

        inhalt_glas.SetActive(false);
        inhalt_shaker.SetActive(false);
       

	}
	
	
}
