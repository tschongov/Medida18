using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trigger : MonoBehaviour
{

    public GameObject Hook;

    void Start()
    {
        Hook.SetActive(false);
    }


    public int count = 0;
    void OnCollisionEnter2D()
    {
        if (count >= 16)
        {
            Hook.SetActive(true);
            StartCoroutine(WaitAndLoadScene());

        }

        else
        {
            count++;
        }


    }
    IEnumerator WaitAndLoadScene()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Chapter Select");
    }
}
