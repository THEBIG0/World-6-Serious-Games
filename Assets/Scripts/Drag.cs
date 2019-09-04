using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour {
    public GameObject drop;

    void Update () {
        Vector3 a = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));
        transform.position = new Vector2(a.x, a.y);
        if (Input.GetMouseButtonUp(0)) {
            Instantiate(drop, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
