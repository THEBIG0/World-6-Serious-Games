using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;
public class SavePlayerName : MonoBehaviour
{
    public GameObject inputName;

   public InputField inputText;
   public string PlayerName;
   public Flowchart flowchart;
    // Start is called before the first frame update
    void Start()
    {
         //PlayerName = PlayerPrefs.GetString("KeyName");
        inputText.text = PlayerName;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SaveText()
    {
        flowchart.SetStringVariable("PlayerName",PlayerName);
        PlayerName = inputText.text;
        //PlayerPrefs.SetString("KeyName",PlayerName);
        print(PlayerName);
        
        //C.NameText = PlayerName;
        //inputName.SetActive(false);
        
    }
}
