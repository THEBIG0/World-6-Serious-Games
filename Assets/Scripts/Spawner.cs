using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
    public GameObject drag;

    void OnMouseDown() {
        Instantiate(drag, transform.position, transform.rotation);
    }
}
