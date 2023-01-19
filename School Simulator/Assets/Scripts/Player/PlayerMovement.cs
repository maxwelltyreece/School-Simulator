using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// This Script uses 2 dimensional vecotrs to map the players movement from keyboard inputs, aswell as
/// prevents the player from moving when interactions are engaged.
/// </summary>
public class PlayerMovement : MonoBehaviour  
{
    //variables are global so that they can be viewed in the Unity inspector
    public float moveSpeed = 5f; 
    public Rigidbody2D rig;
    public Animator animator;
    Vector2 move; // a vector variable is created to log the movement of the player in both the x and y plane. Z plane is not needed as the game is 2 dimensional.
    private static bool playerExists; // variable is static as there will only ever be one instance of the player within the game.

    void Start() // prevents players spawning each time the player enters a new scene
    {
        Debug.Log("PLAYER SPAWN");
        if(!playerExists)
        {
            playerExists = true;
            DontDestroyOnLoad(transform.gameObject);

            PlayerPrefs.SetInt("Frozen", 1);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Update() // a function that is constantly run.
    {
        if(PlayerPrefs.GetInt("Frozen") == 1)
        {
            move.x = Input.GetAxisRaw("Horizontal");  // logs input in the x direction from the players keyboard arrow keys
            move.y = Input.GetAxisRaw("Vertical"); // the same for the y direction
            animator.SetFloat("Horizontal", move.x);  // sets the values from the vector to the animator object 
            animator.SetFloat("Vertical", move.y);
            animator.SetFloat("Speed", move.sqrMagnitude); // sets the speed of movement to the magnitude of the movement vector.
        }
        else
        {
            move.x = 0;
            move.y = 0;
        }
    }

    void FixedUpdate()
    {
        rig.MovePosition(rig.position + move * moveSpeed * Time.fixedDeltaTime); // moves the player to the given position and adds in a time delay between button press and movement.
    }

    public void LoadSave()
    {

    }
}
