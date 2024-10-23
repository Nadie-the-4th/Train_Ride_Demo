using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEditor;

public class Trainscript : MonoBehaviour
{

     public float x;
     public float y;

 public Transform MyParent;

    public Rigidbody2D myRigidbody;

    public Animator anim;
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {

        if(MyParent != null)

        { 
            if (Input.GetKey(KeyCode.D))

            {
                print ("D was pressed!!!");
               x = 3f;

               anim.SetBool("trainmovin", true);
            print ("TRAIN IS MOVING RIGHT trainscript");
            }
 
          }
        

       
        

       

        if(Input.GetKey(KeyCode.A))
          {
            print ("A was pressed!!!");
           x = -3f;
     

              anim.SetBool("trainmovin", true);
               print ("TRAIN IS MOVING LEFT trainscript");
            }
          
        

        if (Input.anyKey == false)
        {
            x = 0f;
        anim.SetBool("trainmovin", false);
        print ("TRAIN IS STOPPED trainscript");
        }

       myRigidbody.velocity = new Vector2 (x,y);


        if(Input.GetKey(KeyCode.S))
       { print("S was pressed!");
         x = 0f;

           anim.SetBool("trainmovin", false);
           print ("TRAIN IS STOPPED trainscript");
    }

    }
}

//if car reaches end
//then teleport back to Start

