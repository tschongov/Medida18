using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class salzrand_lime : MonoBehaviour {

    public GameObject lime_juice;
    public GameObject more_lime_juice;
    public GameObject Hook;

    void Start()
    {
        Hook.SetActive(false);
        lime_juice.SetActive(false);
        more_lime_juice.SetActive(false);
    }

    void OnMouseDown()
    {
        lime_juice.SetActive(true);
        more_lime_juice.SetActive(true);
        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
        Hook.SetActive(true);
        StartCoroutine(WaitAndLoadScene());

    }

    IEnumerator WaitAndLoadScene()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Daiquiri Salzrand Minispiel2");
    }
    }


    


