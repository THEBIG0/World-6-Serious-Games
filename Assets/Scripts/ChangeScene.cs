using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeScene : MonoBehaviour
{
    public DialogueSwitch ds;
    //public GameObject characterModel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    /*void Update()
    {
        buttonPressed();
      
    }*/
    
    /*void buttonPressed()
    {
        if(Input.GetKeyDown(KeyCode.M))
        {
            SceneManager.LoadScene(1);
        }
        
        if(Input.GetKeyDown(KeyCode.K))
        {
            SceneManager.LoadScene(0);
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            SceneManager.LoadScene(2);
        }
        
    }*/

    public void LoadLevel(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        //characterModel.SetActive(true);
        //print(characterModel.activeSelf + " :isCharacterActive");
    }

   /*public void LoadLoungeRoom(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

   public void LoadCookingMiniGame(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
   
   public void LoadHouseFront(string sceneName)
   {
      SceneManager.LoadScene(sceneName);
   }
   
   public void LoadBlockBreaker(string sceneName)
   {
       SceneManager.LoadScene(sceneName);
   }
   
   public void LoadBedRoom(string sceneName)
   {
      SceneManager.LoadScene(sceneName);
   }

   public void LoadPrologue(string sceneName)
   {
      SceneManager.LoadScene(sceneName);
   }*/

   public void LoadStartScreen(string sceneName)
   {
       //SceneManager.LoadScene(0);
      
       ds.ResetGameSession("Start-Screen");
       
   }
}
