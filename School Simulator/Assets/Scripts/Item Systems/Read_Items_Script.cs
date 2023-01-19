using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// script allowing all dialogue objects to call the dialogue box
/// </summary>
public class Read_Items_Script : MonoBehaviour, Interaction_Interface
{
    [SerializeField] private Conversation Item_Lines;
    public void Interaction()
    {
        Debug.Log("ITEM INTERACTION");
        PlayerPrefs.SetInt("Frozen", 0); // player preferencs are effecitvely global variables that can be interacted with in any object script.
        Dialogue.Instance.StartConversation(Item_Lines);
    }

}
