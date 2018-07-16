using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trigger : MonoBehaviour
{

    public GameObject Hook;
    public GameObject Stamp;

    void Start()
    {
        Hook.SetActive(false);
    }


    public int counterX = 0;
    public int counterY = 0;
    
    void Update()
    {

        if (Stamp.GetComponent<Transform>().position.x <5.5)
        {
            counterX++;
        }

        if (counterX >= 1000)
        {
            Hook.SetActive(true);
            StartCoroutine(WaitAndLoadScene());

        }

    }

    IEnumerator WaitAndLoadScene()
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("Chapter Select");
    }
}
