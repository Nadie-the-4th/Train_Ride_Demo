using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouseWhenDragged : MonoBehaviour
{
   private Vector3 mousePos;
  
    private void OnMouseDrag() 
    {
        // Making sure this method gets called when I think it does
        // print("OnMouseDrag() in FollowMouseWhenDragged.cs on which GO:  "+ gameObject);

        // I want this GO to follow my mouse because I want it to seem like player is dragging it
        // Get the position of the mouse by using a method in the Camera class
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            
        print(mousePos+" and also MousePosition" +Input.mousePosition);
            
        // Assign transform.position a new value every frame    
        transform.position = new Vector3(mousePos.x, mousePos.y, transform.position.z);

    }

}
