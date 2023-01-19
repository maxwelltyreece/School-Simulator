using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/// <summary>
/// This code is attached to blank game objects that when the player traverses over will transport them to a new area
/// of the map.
/// </summary>
public class LeavingTrigger : MonoBehaviour
{
    public string RoomToLoad;
    public Vector2 leaveCoordinates; // coordinates of where the player will appear once in the new area
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Debug.Log("EXIT ROOM");
            SceneManager.LoadScene(RoomToLoad); // loads scene via build index.
            //uses vectors to set the players position
            collision.transform.position = new Vector3(leaveCoordinates.x, leaveCoordinates.y, collision.transform.position.z);
        }
    }

 
}
 