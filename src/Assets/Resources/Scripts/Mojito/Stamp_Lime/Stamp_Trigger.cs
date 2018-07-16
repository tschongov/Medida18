using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stamp_Trigger : MonoBehaviour
{

    public GameObject Hook;
    public GameObject Stamp;
    void Start()
    {
        Hook.SetActive(false);
    }

    public int counter = 0;

    void Update()
    {

       

        if (Stamp.GetComponent<Transform>().position.y < -1.3f)
        {
            counter++;
        }

        if (counter >= 300)
        {
            Hook.SetActive(true);
            StartCoroutine(WaitAndLoadScene());

        }


    }

    IEnumerator WaitAndLoadScene()
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("Mojito.Pick_Mint");
    }
}


