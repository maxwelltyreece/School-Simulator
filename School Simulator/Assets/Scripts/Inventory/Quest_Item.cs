using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// asset menu for items needed for specific quests within the game
/// </summary>
[CreateAssetMenu(menuName = "Items/Create new Quest Item")]
public class Quest_Item : Item
{
    [SerializeField] int QuestNumber;
}
