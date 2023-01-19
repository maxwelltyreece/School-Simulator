using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// asset menu for keys within the game
/// </summary>
[CreateAssetMenu(menuName = "Items/Create new Key")]
public class Key_Item : Item
{
    [SerializeField] string colour;
}
