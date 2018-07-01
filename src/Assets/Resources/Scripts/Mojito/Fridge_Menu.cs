using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fridge_Menu : MonoBehaviour {

    public GameObject fridge;
    public GameObject fridge1;
    public GameObject menu;

    void Start()
    {
        fridge1.SetActive(false);
        menu.SetActive(false);
    }

    // Use this for initialization

    void OnMouseDown()
    {
        fridge.SetActive(false);
        fridge1.SetActive(true);
        menu.SetActive(true);
    }
}
