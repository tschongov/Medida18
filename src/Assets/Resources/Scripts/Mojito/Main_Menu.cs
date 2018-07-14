using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_Menu : MonoBehaviour {

    public GameObject mainMenu;
    public GameObject spirituoseMenu;

    public enum menuStates
    {
        Main,
        Spirituose,
        Return,
    }

    public menuStates currentStatus;

    void Start()
    {
        mainMenu.SetActive(false);
        spirituoseMenu.SetActive(false);
       

    }



    void Update()
    {
        switch (currentStatus)
        {
            case menuStates.Main:
                mainMenu.SetActive(true);
               
                spirituoseMenu.SetActive(false);
                break;

            case menuStates.Spirituose:
                mainMenu.SetActive(false);
                
                spirituoseMenu.SetActive(true);
                break;

        
            case menuStates.Return:
                mainMenu.SetActive(false);
                
                spirituoseMenu.SetActive(false);
                break;
        }
    }

    public void OnNextScene()
    {
        SceneManager.LoadScene("Mojito.Cut_Lime");
    }
   

	public void OnRumMode()
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
}
