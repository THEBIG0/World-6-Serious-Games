using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


public class LoadSceneOnClick : MonoBehaviour {
    public int scene;
    void OnMouseDown() {
        SceneManager.LoadScene(scene);
    }
}
