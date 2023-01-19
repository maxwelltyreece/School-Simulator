using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class SortingNumbers : MonoBehaviour
{
    [SerializeField] private string Lines;

    private void Awake()
    {
        System.Random rand = new System.Random(); // differentiates between Unity's definitions for random and System's definition for random, wihich is the one im used to working with

        for (int i = 0; i < 7; i++)
        {
            int number = rand.Next(21);
            Lines = Lines + " " + number.ToString();
        }
    }

}


