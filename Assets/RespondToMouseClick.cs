using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespondToMouseClick : MonoBehaviour
{
    bool red;
    bool blue;
    private SpriteRenderer spriteRenderer;
    public Sprite sadSprite;
    public Sprite happySprite;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        print(spriteRenderer);
    }

    // MonoBehaviour has some (more) useful methods
    void OnMouseOver()
    {
        print ("OnMouseOber!!)");

        if(blue == false)
        {
            print("blue == false in ONMOUSEOVER!!!!!"  +gameObject);

            blue = true;

            spriteRenderer.color = Color.blue;    
            
        }
    }

    void OnMouseExit()
    {
        // That one frame where my mouse starts not being over this object
        if (blue == true)
        {
            spriteRenderer.sprite = sadSprite;

        }

    }

}
