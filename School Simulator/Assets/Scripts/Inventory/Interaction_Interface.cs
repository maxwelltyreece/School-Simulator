using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// interface for all objects in the game that require the player to interact with them. this prevents new objects
/// that the player is supposed to interact with being instanciated without this function accidentaly.
/// </summary>
public interface Interaction_Interface 
{
    void Interaction();
}
