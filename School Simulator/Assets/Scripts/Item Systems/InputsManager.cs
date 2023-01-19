using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// class managing all the interactions the player can engage with
/// </summary>
public class InputsManager : MonoBehaviour
{
    //variable for where the player inputs the data
    public GameObject PlayerInputBox;
    public InputField PlayerInputBoxField;

    //allows the functions to be called in other classes
    public static InputsManager InputInstance { get; private set; }

    void Start() // prevents new instances being created when a new scene is entered
    {
        if (InputInstance == null)
        {
            InputInstance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void StartInputs() // function to enable the input box
    {
        PlayerInputBox.SetActive(true);
        Debug.Log("INPUT BOX ENABLED");
    }
}
