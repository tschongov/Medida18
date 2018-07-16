using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class salzrand_teil2 : MonoBehaviour {

    GameObject glass;
     public GameObject Hook;
    void Start()
    {
        Hook.SetActive(false);
        glass = GameObject.Find("glas_sicht");
    }

    void OnMouseDrag()
    {
        Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = (pos);
    }
    
    void Update()
    {

        //Debug.Log(glass.GetComponent<Transform>().position.y);
        if (glass.GetComponent<Transform>().position.y <= -2.3f)
        {
            Hook.SetActive(true);
            StartCoroutine(WaitAndLoadScene());
        }

       
    }

    IEnumerator WaitAndLoadScene()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Daiquiri Zutaten");
    }
}
