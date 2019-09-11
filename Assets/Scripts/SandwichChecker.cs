using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SandwichChecker : MonoBehaviour {
    public GameObject text1;
    void OnMouseDown() {
        Object[] drops = GameObject.FindObjectsOfType(typeof(Drop));
        if(drops.Length == 5) {
            text1.GetComponent<UnityEngine.UI.Text>().text = "Well Done!";
        } else {
            text1.GetComponent<UnityEngine.UI.Text>().text = "Hmm...";
        }
    }
}
