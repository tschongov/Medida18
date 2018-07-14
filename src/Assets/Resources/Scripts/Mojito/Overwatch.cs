using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Overwatch : MonoBehaviour {

    GameObject lime;
    public GameObject dBox;
    public GameObject Hook;

    void Start()
    {
        lime = GameObject.Find("Limetten.exe_0");
        lime.SetActive(false);
        Hook.SetActive(false);
    }

    void Update()
    {
        if (!dBox.activeSelf)
        {
            lime.SetActive(true);
        }
    }
}
