using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene_Click : MonoBehaviour
{




    public GameObject Hook;
    // Use this for initialization
    void OnMouseDown()
    {

        Hook.SetActive(true);
        StartCoroutine(WaitAndLoadScene());

    }

    IEnumerator WaitAndLoadScene()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Mojito.Cut_Lime");
    }
}
