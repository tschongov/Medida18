using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class becher_movetowards : MonoBehaviour {

    public Vector2 aPosition = new Vector2(3,3);
    public GameObject inhalt;
    public float waitTime = 1f;
    float timer;
	
	void Update () {

        transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), aPosition, 3 * Time.deltaTime);
        timer += Time.deltaTime;

    }

    void OnMouseDown()
    {
        inhalt.SetActive(true);
        if (timer > waitTime)
        {
            SceneManager.LoadScene("Daiquiri Zutaten");
        }
        else return;
    }
}
