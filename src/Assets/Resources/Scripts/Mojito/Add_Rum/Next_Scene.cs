using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Next_Scene : MonoBehaviour {

    public GameObject glas;
    public GameObject jigger;
    public GameObject ice;
    public GameObject Hook;


    void Start()
    {
        Hook.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {

        if (glas.activeSelf && jigger.activeSelf && ice.activeSelf)
        {
            Hook.SetActive(true);
            StartCoroutine(WaitAndLoadScene());
        }
    }

    IEnumerator WaitAndLoadScene()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Mojito_Muddle");
    }

}
