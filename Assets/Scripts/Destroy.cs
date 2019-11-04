using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Collision2D = UnityEngine.Collision2D;
using Fungus;
public class Destroy : MonoBehaviour
{
    //public bool bagDestroyed = false;
    //public Flowchart flowchart;
    public Listiner L;

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.name == "blackRubbishBin")
        {
            L.EventTrue();
            gameObject.SetActive(false);   
            //Destroy(GameObject.Find("RubbishBag"));
            
            
        }
    }

   
    
}
