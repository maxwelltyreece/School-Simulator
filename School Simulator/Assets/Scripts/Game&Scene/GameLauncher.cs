using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLauncher : MonoBehaviour
{
    void Start()
    {
        PlayerPrefs.SetInt("MoneyCounter", 0); // global instances of player attrributes are set that can be accesssed in any script without instantiation.
        PlayerPrefs.SetInt("Frozen", 0);
        PlayerPrefs.SetInt("M1", 0);
        PlayerPrefs.SetInt("M2", 0);
        PlayerPrefs.SetInt("M3", 0);
        PlayerPrefs.SetInt("M4", 0);
        PlayerPrefs.SetInt("M5", 0);
    }
}
