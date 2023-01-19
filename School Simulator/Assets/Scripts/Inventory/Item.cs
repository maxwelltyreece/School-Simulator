using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// a parent class for all other item classes to inherit from
/// </summary>
public class Item : ScriptableObject
{
    //general variables for all items
    [SerializeField] private string ItemName;
    [SerializeField] private string ItemDescription;
    [SerializeField] private Sprite ItemImage;

    // properties to expose the private variables;
    public string Name => ItemName;
    public string Description => ItemDescription;
    public Sprite Image => ItemImage;
}

    