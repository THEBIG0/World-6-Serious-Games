using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class Listiner : MonoBehaviour
{
   // private Destroy d;
    public Flowchart flowchart;
    public void EventTrue()
    {
        print("IfBagDestroyed should be true");
     flowchart.SetBooleanVariable("IfBagDestroyed",true);
        
    }
}
