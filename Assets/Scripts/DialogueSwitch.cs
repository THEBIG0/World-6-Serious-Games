using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Fungus;
public class DialogueSwitch : MonoBehaviour
{
    public bool hasSaidBefore;
    //public bool isCharacterActive;
    public Flowchart flowchart;
   string sceneName;
   public View kitchenView;
   public Camera mainCamera;
   public GameObject characterModel;
   public Character character;
   private int counter = 0;
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
        //isCharacterActive = flowchart.GetBooleanVariable("IsCharacterActive");
        print(hasSaidBefore);
        if (sceneName == "CookingGame")
        {
            counter = 0;
            characterModel.SetActive(false);
            print("character should be disabled");
            counter = 1;
        }
        if (sceneName == "CookingGame" || sceneName == "Lounge-Room")
        {
            flowchart.SetBooleanVariable("IfSaidBefore", true);
        }
        else if (sceneName == "Kitchen")
        {
            flowchart.SetBooleanVariable("IfSaidBefore", false);
            //flowchart.SetBooleanVariable("IsCharacterActive", true);
            if (counter == 1)
            {
                //flowchart.SetBooleanVariable("IsCharacterActive", true);
                characterModel.SetActive(true);
                counter = 0;
            }
        }
        
        //bug: character model still appeared in the cooking game so i need to disable it then reenable it 
        if (sceneName == "CookingGame")
        {
            characterModel.SetActive(false);
            print("character should be disabled");
        }

       
    }
}
