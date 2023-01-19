using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/// <summary>
/// This code effectively a function that is attached to buttons that changes the players scene when pressed on.
/// </summary>
public class SceneNavigator : MonoBehaviour
{
    public void ChangeScene(int SceneToLoadIndex)
    {
        SceneManager.LoadScene(SceneToLoadIndex); // changes scene via build index.
    }
}
