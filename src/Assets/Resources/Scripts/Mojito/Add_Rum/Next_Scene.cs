using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Next_Scene : MonoBehaviour {

    public GameObject glas;
    public GameObject jigger;
    public GameObject jigger2;
    public GameObject ice;
    public GameObject Hook;
    public GameObject dialogue;


    void Start()
    {
        Hook.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {

        if (glas.activeSelf && jigger.activeSelf && ice.activeSelf && jigger2.activeSelf)
        {
            Hook.SetActive(true);

            if (!dialogue.activeSelf)
            {
                StartCoroutine(WaitAndLoadScene());
            }
        }
    }

    IEnumerator WaitAndLoadScene()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Mojito_Muddle");
    }

}
