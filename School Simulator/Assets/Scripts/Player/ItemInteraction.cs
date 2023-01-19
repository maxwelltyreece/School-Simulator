using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// code to allow player to react when nearby interactable objects
/// </summary>
public class ItemInteraction : MonoBehaviour 
{
    public Transform InteractionPoint;  // sets the point on the player that when in contact with an item will trigger it

    public LayerMask ChosenLayer; // Sets the layer that the interactables are in within the scene
    private float detectionLength = 0.1f; // sets the length away from an item the player can be for them to detect it.
    public GameObject SelectedItem; // a gameobject that is defined if an item is in the players detection radius.

    
    //checks possible interactions and keystrokes once per frame
    void Update() 
    {
        if (NearSomething())
        {
            if (PickUpButton())
            {
                SelectedItem.GetComponent<Interaction_Interface>()?.Interaction(); 
            }
        }
    }
    //function to detect if their is an interactable object in the player's radius
    bool NearSomething()  
    {
        Collider2D item = Physics2D.OverlapCircle(InteractionPoint.position,detectionLength,ChosenLayer); // assigns the value of any collider in the players detection radius to the variable item.
        if(item == null) // if there is no item in the radiu, as the item will have no value
        {
            SelectedItem = null; // removes any previous items once they leave the detection radius
            return false; // if no items are detected any sequential code wont progress.
        }
        SelectedItem = item.gameObject; // sets the gameobject(item) that corresponds to the box collider in the players detection radius to selected item 
        return true;
        

    }
    //checks if the player presses the interaction button
    bool PickUpButton()
    {
        return Input.GetKeyDown(KeyCode.Space);  // if the space bar is pressed, returns a true value.
    }

   
}
