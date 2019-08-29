using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        buttonPressed();
    }
    
    void buttonPressed()
    {
        if(Input.GetKeyDown(KeyCode.M))
        {
            SceneManager.LoadScene(1);
        }
        
        if(Input.GetKeyDown(KeyCode.K))
        {
            SceneManager.LoadScene(0);
        }
        
    }
}
