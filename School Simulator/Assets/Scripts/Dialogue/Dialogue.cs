using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
/// <summary>
/// class managing all speech pop ups that the player interacts with
/// </summary>
public class Dialogue : MonoBehaviour
{
   // variables for where the text data is sent to and displayed
    [SerializeField] private GameObject talkBox;
    //[SerializeField] private TextMeshProUGUI DialogueBox;
    [SerializeField] private Text DialogueBox;
    public int textSequencer = 0; // count for the line of text
    
    public static Dialogue Instance { get; private set; } // a static object from the dialogue class, so that the code can be referenced in other classes

    void Start() // prefents new instances being created when new scenes are entered
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
  
           

    Conversation inputConversation; // allows the 'next line' function to sequence as all of the speech data is saved in this variable
    
    public void StartConversation(Conversation inputConversation) // function for beginning a speech
    {
        this.inputConversation = inputConversation; // at the start all of the speech data is saved within the class
        talkBox.SetActive(true);
        DialogueBox.text = "";
        DialogueBox.text = inputConversation.Lines[0];
        
    }

    public void NextLine() // function for progressing to the next line
    {
        if (Input.GetKeyDown(KeyCode.Q) == true) // only sequences if the player presses a key, which is checked once per frame below
        {
            textSequencer = textSequencer + 1;
            if (textSequencer < inputConversation.Lines.Count)
            {

                DialogueBox.text = inputConversation.Lines[textSequencer];
            }
            else
            {
                talkBox.SetActive(false);
                textSequencer = 0;
                PlayerPrefs.SetInt("Frozen", 1);
            }
        }
    }

    void Update()
    {
        Instance.NextLine();
    }

}


[System.Serializable]

public class Conversation // class for all lines of dialogue, saved as a list of strings
{
    [SerializeField] List<string> lines; 
    public List<string> Lines { get { return lines; } }
}