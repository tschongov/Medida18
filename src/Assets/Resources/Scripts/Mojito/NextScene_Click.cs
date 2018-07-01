using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene_Click : MonoBehaviour {

    public int i;
	void OnMouseDown()
    {
        SceneManager.LoadScene(i);
    }
}
