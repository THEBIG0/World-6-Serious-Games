using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShoppingSpawner : MonoBehaviour {
    public GameObject spawner;


    private void Start() {
        InvokeRepeating("spawn", 0f, 3.5f);
        InvokeRepeating("spawn", 1.5f, 5.5f);      //some sort of random-ish seeming spawn timers
    }

    void spawn() {
        int r = (int)Random.Range(0f, 2.99f);
        GameObject s = Instantiate(spawner, transform.position, transform.rotation);
        s.transform.position = new Vector3(12, 3 + (r * 1.5f), 0);
    }
}
