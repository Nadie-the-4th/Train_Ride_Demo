using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
   public float followSpeed = 2f;
   public Transform target;
   
   public float yOffset = 25f;
   void Update()
   {
    Vector3 newPos = new Vector3(target.position.x, target.position.y + 25f);
    transform.position = Vector3.Slerp(transform.position, newPos, followSpeed*Time.deltaTime);


   }


}

