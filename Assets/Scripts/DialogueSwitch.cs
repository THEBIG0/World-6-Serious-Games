using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Fungus;
public class DialogueSwitch : MonoBehaviour
{
    public bool hasSaidBefore;
    public bool hasSaidBefore2;

    public bool ifBagDestroyed;
    //public bool isCharacterActive;
    public Flowchart flowchart;
   string sceneName;
   public View kitchenView;
   public Camera mainCamera;
   public GameObject characterModel;
   public Character character;
   public GameObject characterModel2;
      public Character character2;
      public GameObject characterModel3;
            public Character character3;
      public SayDialog sayDialog;
      public SayDialog sayDialogSlow;
      public Stage stage;
      public GameObject canvas;
      public GameObject arrowButton;
      public GameObject ListinerObj;
      public GameObject RubbishBag;
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
            Destroy(character2);
            Destroy(characterModel2);
            Destroy(character3);
            Destroy(characterModel3);
            Destroy(sayDialog);
            Destroy(sayDialogSlow);
            Destroy(stage);
            Destroy(canvas);
            Destroy(arrowButton);
            Destroy(ListinerObj);
            Destroy(RubbishBag);
            
        }
        else
        {
            DontDestroyOnLoad(gameObject);
            DontDestroyOnLoad(kitchenView);
            DontDestroyOnLoad(mainCamera);
            DontDestroyOnLoad(characterModel);
            DontDestroyOnLoad(character);
            DontDestroyOnLoad(characterModel2);
            DontDestroyOnLoad(character2);
            DontDestroyOnLoad(characterModel3);
            DontDestroyOnLoad(character3);
            DontDestroyOnLoad(sayDialog);
            DontDestroyOnLoad(sayDialogSlow);
            DontDestroyOnLoad(stage);
            DontDestroyOnLoad(canvas);
            DontDestroyOnLoad(arrowButton);
            DontDestroyOnLoad(ListinerObj);
            DontDestroyOnLoad(RubbishBag);
        }
        

       
       //print(hasSaidBefore);

    }

    void Update()
    {
        
        Scene currentScene = SceneManager.GetActiveScene(); 
        sceneName = currentScene.name;
        hasSaidBefore = flowchart.GetBooleanVariable("IfSaidBefore");
        hasSaidBefore2 = flowchart.GetBooleanVariable("IfSaidBefore2");
        ifBagDestroyed = flowchart.GetBooleanVariable("IfBagDestroyed");
        //isCharacterActive = flowchart.GetBooleanVariable("IsCharacterActive");
        print(hasSaidBefore);
        if (sceneName == "CookingGame" || sceneName =="BlockBreaker")
        {
            flowchart.SetBooleanVariable("IfSaidBefore2", true);
            counter = 0;
            canvas.SetActive(false);
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
                canvas.SetActive(true);
                counter = 0;
            }
        }

        if (sceneName == "Lounge-Room")
        {
            flowchart.SetBooleanVariable("IfSaidBefore2", false);
        }
        
        //bug: character model still appeared in the cooking game so i need to disable it then reenable it 
        if (sceneName == "CookingGame")
        {
            characterModel.SetActive(false);
            print("character should be disabled");
        }

       

       
    }

   
}
