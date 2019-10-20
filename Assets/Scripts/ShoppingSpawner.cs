using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShoppingSpawner : MonoBehaviour {
    public GameObject spawner;
    public GameObject[] drags;
    public Sprite[] sprites;

    private void Start() {
        InvokeRepeating("spawn", 0f, 3.5f);
        InvokeRepeating("spawn", 1.5f, 5.5f);      //some sort of random-ish seeming spawn timers
    }

    void spawn() {
        int r = (int)Random.Range(0f, 2.99f);
        int r2 = (int)Random.Range(0f, sprites.Length - 0.01f);
        GameObject s = Instantiate(spawner, transform.position, transform.rotation);
        s.transform.position = new Vector3(12, 1 + (r * 1.5f), 0);
        s.GetComponent<Spawner>().drag = drags[r2];
        s.GetComponent<SpriteRenderer>().sprite = sprites[r2];
        
    }
}
