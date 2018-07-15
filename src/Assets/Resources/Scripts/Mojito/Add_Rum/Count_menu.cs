using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Count_menu : MonoBehaviour {

    public GameObject Inputfield;
    public InputField countsfield;
    public GameObject jigger;
    public GameObject WrongDialogue;

    private string counts;

    void Start()
    {
        Inputfield.SetActive(false);
        jigger.SetActive(false);
        WrongDialogue.SetActive(false);
    }

    public void OnSubmit()
    {
        counts = countsfield.text;
        if (counts == "4cl" || counts == "40ml" || counts == "4" || counts == "5" || counts == "5cl" || counts == "50ml")
        {
            Inputfield.SetActive(false);
            jigger.SetActive(true);
        }
        else
        {
            WrongDialogue.SetActive(true);
        }
    }



   

}
