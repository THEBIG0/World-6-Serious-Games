using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShoppingChecker : MonoBehaviour {
    public GameObject text1;
    void OnMouseDown() {
        int score = 0;
        MonoBehaviour[] drops = (MonoBehaviour[])GameObject.FindObjectsOfType(typeof(Drop));
        MonoBehaviour[] shoppingList = (MonoBehaviour[])GameObject.FindObjectsOfType<Ingredient>();
        if (drops.Length == 3) {        //if correct number of items, add a point
            score++;
        }
        int inScene = 0;        //check how many of the things on the shopping list are in the scene
        int correct = 0;
        for (int i = 0; i < shoppingList.Length; i++) {
            for(int p = 0; p < drops.Length; p++) {
                if (shoppingList[i].GetComponent<SpriteRenderer>().sprite.name[0] == drops[p].name[0]) {        //compares first characters of shopping list sprite name and cart item name
                    inScene++;
                    break;
                }
            }
        }
        for (int i = 0; i < drops.Length; i++) {        //check how many of the drops match something on the shopping list
            for (int p = 0; p < shoppingList.Length; p++) {
                if (shoppingList[p].GetComponent<SpriteRenderer>().sprite.name[0] == drops[i].name[0]) {
                    correct++;
                    break;
                }
            }
        }
        if (inScene == 3 && correct == drops.Length) {      //if everything on shopping list present and also everything present on shopping list, add a point
            score++;
        }
        int visible = 0;
        for(int i = 0; i < drops.Length; i++) {
            if (drops[i].GetComponent<Renderer>().isVisible) {
                visible++;
            }
        }
        if(visible == drops.Length) {   //add a point if everything on the screen, aka not fallen out of the cart
            score++;
        }

        string[] texts = { "Absolutely not...", "Hmm...", "Not quite...", "Well Done!" };
        text1.GetComponent<UnityEngine.UI.Text>().text = texts[score];
        Debug.Log(score);
    }
}
