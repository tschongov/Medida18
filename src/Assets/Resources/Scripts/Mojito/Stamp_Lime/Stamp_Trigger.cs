using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stamp_Trigger : MonoBehaviour {

    public GameObject Hook;
    void Start()
    {
        Hook.SetActive(false);
    }

    public int count = 0;

	void OnCollisionEnter2D()
    {

        if (count > 3)
        {
            Hook.SetActive(true);
            StartCoroutine(WaitAndLoadScene());
        }
        Debug.Log("Bam:  " + count);

        count++;
    }

    IEnumerator WaitAndLoadScene()
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("Mojito.Pick_Mint");
    }
}
 
