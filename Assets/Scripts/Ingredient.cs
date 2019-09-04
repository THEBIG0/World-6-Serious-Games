using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ingredient : MonoBehaviour {
    public Sprite[] sprites;
    
    void Start() {
        gameObject.GetComponent<SpriteRenderer>().sprite = sprites[(int)(Random.value * sprites.Length)];
    }
}
