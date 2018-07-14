using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class salzrand_lime : MonoBehaviour {

    public GameObject lime_juice;
    public GameObject more_lime_juice;

    void Start()
    {
        lime_juice.SetActive(false);
        more_lime_juice.SetActive(false);
    }

    void OnMouseDown()
    {
        lime_juice.SetActive(true);
        more_lime_juice.SetActive(true);
        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
        SceneManager.LoadScene("Daiquiri Salzrand Minispiel2");
    }
}

    


