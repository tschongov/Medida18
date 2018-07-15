using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue : MonoBehaviour {

    public GameObject dBox;
    public GameObject dtext;
    public GameObject avatar;


    // Use this for initialization
    

    // Update is called once per frame
    void Update()
    {
        if (dBox.activeSelf && Input.GetMouseButtonDown(0))
        {
            dBox.SetActive(false);
            avatar.SetActive(false);
        }
    }
}

