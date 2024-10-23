using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenToWorldPointDemo : MonoBehaviour
{
    public Vector3 mousePos;
    
    void OnMouseDown()
    {
        print(gameObject.name);

    }

    // every frame mouse id down on this GO
    void OnMouseDrag()
    {
        // Changing the screen base mouse position to world space GO
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);


        transform.position = new Vector3(mousePos.x, mousePos.y, transform.position.z);
    }

}
