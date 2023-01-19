using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Money_Manager : MonoBehaviour
{
    public Text MoneyCounter;
    public Scene MainScene;
    private static bool moneyManager;
    private static Renderer[] childRenders;


    private void Start()
    {
        if (!moneyManager)
        {
            DontDestroyOnLoad(transform.gameObject);

            moneyManager = true;
            childRenders = GetComponentsInChildren<Renderer>();
        }
        else
        {
            Destroy(gameObject);
        }

    }

    void Update()
    {
        MoneyCounter.text = "Money: " + PlayerPrefs.GetInt("MoneyCounter").ToString();
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(1))
        {
            foreach (Renderer r in childRenders)
                r.enabled = true;
        }
        else
        {
            foreach (Renderer r in childRenders)
                r.enabled = false;
        }
    }
}
