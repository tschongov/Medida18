using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lime : MonoBehaviour
{
    public GameObject salt;
    public GameObject Hook;

    void Start()
    {
        Hook.SetActive(false);
    }
    void OnMouseDown()
    {
        if (salt.activeSelf) {
            Hook.SetActive(true);
            StartCoroutine(WaitAndLoadScene());
        }


    }

    IEnumerator WaitAndLoadScene()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Daiquiri Salzrand Minispiel1");
    }
}
