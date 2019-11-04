﻿using System.Collections;
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

    public void LoadKitchen()
    {
        SceneManager.LoadScene(3);
        //characterModel.SetActive(true);
        //print(characterModel.activeSelf + " :isCharacterActive");
    }

   public void LoadLoungeRoom()
    {
        SceneManager.LoadScene(5);
    }

   public void LoadCookingMiniGame()
    {
        SceneManager.LoadScene(4);
    }
   
   public void LoadHouseFront()
   {
       SceneManager.LoadScene(2);
   }
   
   public void LoadBlockBreaker()
   {
       SceneManager.LoadScene(6);
   }
   
   public void LoadBedRoom()
   {
       SceneManager.LoadScene(7);
   }

   public void LoadPrologue()
   {
       SceneManager.LoadScene(1);
   }

   public void LoadStartScreen()
   {
       //SceneManager.LoadScene(0);
      
       ds.ResetGameSession();
       
   }
}
