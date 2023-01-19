using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// script allowing all input objects to call up the input box
/// </summary>
public class Input_Items_Script : MonoBehaviour, Interaction_Interface
{
    public void Interaction()
    {
        Debug.Log("INPUT INTERACTION");
        InputsManager.InputInstance.StartInputs();   
    }
}
