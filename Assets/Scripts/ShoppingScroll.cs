using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShoppingScroll : MonoBehaviour {

    void Update() {
        transform.Translate(Vector2.left * Time.deltaTime * 6f);
        if(transform.position.x < -25) {
            Destroy(gameObject);
        }
    }
}
