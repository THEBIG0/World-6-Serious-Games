using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SandwichChecker : MonoBehaviour {
    public GameObject text1;
    void OnMouseDown() {
        int score = 0;
        MonoBehaviour[] drops = (MonoBehaviour[])GameObject.FindObjectsOfType(typeof(Drop));
        //order drops by y coord, lowest first
        for (int p = 0; p < drops.Length; p++) {
            for (int i = 0; i < drops.Length - 1; i++) {
                if (drops[i].transform.position.y > drops[i + 1].transform.position.y) {    //bubble? sort
                    MonoBehaviour t = drops[i];
                    drops[i] = drops[i + 1];
                    drops[i + 1] = t;
                }
            }
        }
        if (drops.Length == 5) {        //if correct number of ingredients placed
            int breads = 0;
            for(int i = 0; i < drops.Length; i++) { //count all the bread in the scene
                if(drops[i].name.Substring(0, 5) == "bread") {
                    breads++;
                }
            }
            if(breads == 2) {           //if 2 slices of bread and 5 ingredients total, add one point
                score++;
                Debug.Log("bread is there");
            }
        }
        int misaligned = 0;
        for(int i = 1; i < drops.Length; i++) {     //check how many ingredients are misaligned with the first one placed
            float tolerance = 1.2f;
            if(drops[i].transform.position.x > drops[0].transform.position.x + tolerance || drops[i].transform.position.x < drops[0].transform.position.x - tolerance) {
                misaligned++;
            }
        }
        if(misaligned == 0 && drops.Length > 2) {       //give a point if all ingredients are lined up and there's at least 3 of them
            score++;
            Debug.Log("ingredients lined up");
        }
        score++;    //todo: check that the ingredients match the ones on the side, just giving a point for now
        string[] texts = { "Absolutely not...", "Hmm...", "Not quite...", "Well Done!" };
        text1.GetComponent<UnityEngine.UI.Text>().text = texts[score];
        Debug.Log(score);
    }
}
