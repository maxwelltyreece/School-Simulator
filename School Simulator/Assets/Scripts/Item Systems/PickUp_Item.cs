using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp_Item : MonoBehaviour, Interaction_Interface
{
    [SerializeField] private Item Item;

    public void Interaction()
    {

        if (Inventory.Instance.AddItem(Item))
        {
            gameObject.SetActive(false);
        }
    }
}
