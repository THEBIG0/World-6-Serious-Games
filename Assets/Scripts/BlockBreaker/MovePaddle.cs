using System;
using System.Collections;
using System.Collections.Generic;
using Fungus;
using UnityEngine;
using Collision2D = UnityEngine.Collision2D;

//Source-Code: https://answers.unity.com/questions/929562/limiting-drag-and-drop.html

public class MovePaddle : MonoBehaviour
{
    
    private Vector3 offset;

    
    void OnMouseDown()
      {
        
          offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y,0));
      }
      
      void OnMouseDrag()
      {
          
          //11.3 -5.75 x axis limits
          //-3.75 0 y axis limits
           
              Vector3 curScreenPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition) + offset;
             
              curScreenPoint.x = Mathf.Clamp(curScreenPoint.x, -7f, 9f);
              curScreenPoint.y = Mathf.Clamp(curScreenPoint.y, -3.75f, 0f);
              curScreenPoint.z = transform.position.z;
      
              transform.position = curScreenPoint;
          
      }

     
}
