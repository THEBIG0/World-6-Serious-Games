using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Fungus;
public class DialogueSwitch : MonoBehaviour
{
    public bool hasSaidBefore;
    
    public Flowchart flowchart;
   string sceneName;
   public View kitchenView;
   public Camera mainCamera;
   public GameObject characterModel;
   public Character character;
    private void Awake()
    {
     /*Scene currentScene = SceneManager.GetActiveScene(); 
     sceneName = currentScene.name;
     print(sceneName);
     hasSaidBefore = flowchart.GetBooleanVariable("IfSaidBefore");
     if (sceneName == "CookingGame")
     {
         hasSaidBefore = true;
     }*/
        
        int numGameSessions = FindObjectsOfType<DialogueSwitch>().Length;

        if (numGameSessions > 1)
        {
            Destroy(gameObject);
            Destroy(kitchenView);
            Destroy(mainCamera);
            Destroy(characterModel);
            Destroy(character);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
            DontDestroyOnLoad(kitchenView);
            DontDestroyOnLoad(mainCamera);
            DontDestroyOnLoad(characterModel);
            DontDestroyOnLoad(character);
        }
        

       
       //print(hasSaidBefore);

    }

    void Update()
    {
        
        Scene currentScene = SceneManager.GetActiveScene(); 
        sceneName = currentScene.name;
        hasSaidBefore = flowchart.GetBooleanVariable("IfSaidBefore");
        print(hasSaidBefore);
        if (sceneName == "CookingGame")
        {
            flowchart.SetBooleanVariable("IfSaidBefore", true);
        }
       
    }
}
