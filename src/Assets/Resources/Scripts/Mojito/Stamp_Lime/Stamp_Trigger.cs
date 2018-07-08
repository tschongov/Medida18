using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stamp_Trigger : MonoBehaviour {

    public int count = 0;

	void OnCollisionEnter2D()
    {
        if (count > 3)
        {
            SceneManager.LoadScene("Mojito.Pick_Mint");
        }
        Debug.Log("Bam:  " + count);
        count++;
    }
}
 
