using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Count_menu : MonoBehaviour {

    public GameObject Inputfield;
    public InputField countsfield;
    public GameObject jigger;

    private string counts;

    void Start()
    {
        Inputfield.SetActive(false);
        jigger.SetActive(false);
    }

    public void OnSubmit()
    {
        counts = countsfield.text;
    }

    void Update()
    {
        if (counts == "4cl" || counts == "40ml" || counts == "4")
        {
            Inputfield.SetActive(false);
            jigger.SetActive(true);
        }
    }

}
