using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class salzrand_teil1 : MonoBehaviour
{

    public Texture2D lime;
    public CursorMode cursor_mode = CursorMode.Auto;
    public Vector2 hot_spot = Vector2.zero;

    void OnMouseEnter()
    {
        Cursor.SetCursor(lime, hot_spot, cursor_mode);
    }

   
}
