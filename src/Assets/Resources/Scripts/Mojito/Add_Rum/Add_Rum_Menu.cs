using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Add_Rum_Menu : MonoBehaviour {


    public GameObject mainMenu;
    public GameObject spirituoseMenu;
    public GameObject softdrinksMenu;
    public GameObject counts_Field;


    public GameObject emptyGlas;
    public GameObject fullGlas;
    public GameObject iceCubes;
    public GameObject jigger;
    public GameObject jigger2;

    public GameObject iceDialogue;
    public enum menuStates
    {
        Main,
        Spirituose,
        Softdrinks,
        Return,
    }

    public menuStates currentStatus;

    void Start()
    {
        mainMenu.SetActive(false);
        spirituoseMenu.SetActive(false);
        softdrinksMenu.SetActive(false);
        iceDialogue.SetActive(false);

        fullGlas.SetActive(false);
    }



    void Update()
    {
        switch (currentStatus)
        {
            case menuStates.Main:
                mainMenu.SetActive(true);
                spirituoseMenu.SetActive(false);
                softdrinksMenu.SetActive(false);
                break;

            case menuStates.Spirituose:
                mainMenu.SetActive(false);
                spirituoseMenu.SetActive(true);
                softdrinksMenu.SetActive(false);
                break;

            case menuStates.Softdrinks:
                mainMenu.SetActive(false);
                spirituoseMenu.SetActive(false);
                softdrinksMenu.SetActive(true);
                break;



            case menuStates.Return:
                mainMenu.SetActive(false);
                spirituoseMenu.SetActive(false);
                softdrinksMenu.SetActive(false);
                break;
        }
    }

    public void OnNextScene()
    {
        SceneManager.LoadScene("Mojito.Cut_Lime");
    }
    public void OnIceMode()
    {
        iceCubes.SetActive(true);
        currentStatus = menuStates.Return;
        iceDialogue.SetActive(true);
        
    }

    public void OnSoftdrinksMode()
    {
        currentStatus = menuStates.Softdrinks;
    }

    public void OnSodaMode()
    {
        emptyGlas.SetActive(false);
        fullGlas.SetActive(true);
        currentStatus = menuStates.Return;
    }

    public void OnSpiritMode()
    {
        Debug.Log("you clicked the rum one");
        currentStatus = menuStates.Spirituose;
    }

    public void OnMenuStartMode()
    {
        Debug.Log("you clicked the menu");
        currentStatus = menuStates.Main;
    }

    public void OnGoBackMode()
    {
        currentStatus = menuStates.Return;
    }

    public void OnRumMode()
    {
        currentStatus = menuStates.Return;
        counts_Field.SetActive(true);
    }

    public void OnSucreMode()
    {
        jigger2.SetActive(true);
        currentStatus = menuStates.Return;
    }

}
