using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnNextScene : MonoBehaviour {

    public string chapter;
    public GameObject Hook;

    void Start()
    {
        Hook.SetActive(false);
    }
    // Use this for initialization
    void OnMouseDown()
    {

        Hook.SetActive(true);
        StartCoroutine(WaitAndLoadScene());

    }

    IEnumerator WaitAndLoadScene()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(chapter);

    }
}
