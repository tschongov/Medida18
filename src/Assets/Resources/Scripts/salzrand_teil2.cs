using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class salzrand_teil2 : MonoBehaviour {

  
    void OnMouseDrag()
    {
        Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = (pos);
    }
    


}
