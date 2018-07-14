using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Multiple_Diaglogue : MonoBehaviour
{
    public GameObject dBox;
    public Text dtext;
    public GameObject avatar;
    public string[] dLines;
    public int currentline;
    // Use this for initialization

    // Update is called once per frame
    void Update()
    {
        if (dBox.activeSelf && Input.GetMouseButtonDown(0))
        {
            currentline++;
        }

        if (currentline >= dLines.Length)
        {
            dBox.SetActive(false);
            avatar.SetActive(false);
            currentline = 0;
        }

        dtext.text = dLines[currentline];

    }


}