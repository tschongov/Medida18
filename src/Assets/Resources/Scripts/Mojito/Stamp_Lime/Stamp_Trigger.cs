using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stamp_Trigger : MonoBehaviour {


    public int count = 5; 

    public GameObject target;
	void OnCollisionEnter(Collision col)
    {
       if(col.gameObject == target)
        {
            if (count >= 3)
            SceneManager.LoadScene(4);
        }

        count++;
    }
}
 
