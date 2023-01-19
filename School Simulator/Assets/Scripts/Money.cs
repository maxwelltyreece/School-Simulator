using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// class to display money counter on screen 
/// </summary>
public class Money : MonoBehaviour, Interaction_Interface
{
    public void Interaction()
    {
        PlayerPrefs.SetInt("MoneyCounter", PlayerPrefs.GetInt("MoneyCounter")+1);
        gameObject.SetActive(false);
    }
}
