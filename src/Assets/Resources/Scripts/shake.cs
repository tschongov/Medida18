using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class shake : MonoBehaviour {

    public GameObject Shaker;
    public GameObject Hook;
    int counter = 0;

    void Start()
    {
        Hook.SetActive(false);
    }
    void Update()
    {

        if (Shaker.GetComponent<Transform>().position.y > 2 || Shaker.GetComponent<Transform>().position.y < -2){
            counter++;
        }

        if (counter >= 150)
        {
            Hook.SetActive(true);
            StartCoroutine(WaitAndLoadScene());

        }

    }

    IEnumerator WaitAndLoadScene()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Daiquiri Fine Strain");
    }

    void OnMouseDrag()
    {

        Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = (pos);

    }
    
 }
