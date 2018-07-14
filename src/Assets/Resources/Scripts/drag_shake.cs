using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class drag_shake : MonoBehaviour {

    public float waitTime = 6f;
    float timer;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > waitTime)
        {
            SceneManager.LoadScene("Daiquiri Fine Strain");
        }
        else return;
    }
}
