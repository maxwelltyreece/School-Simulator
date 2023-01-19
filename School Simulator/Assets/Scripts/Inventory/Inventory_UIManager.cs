using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// this code manages the visual updating of the players on screen representation of their inventory.
/// </summary>
public class Inventory_UIManager : MonoBehaviour
{
    public GameObject InventoryUI;
    [SerializeField] private Image ItemSlot1; // images of the players slots
    [SerializeField] private Image ItemSlot2;
    [SerializeField] private Image ItemSlot3;
    public GameObject Player;
  

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I) == true) // only sequences if the player presses a key, which is checked once per frame below
        {
            // when the player opens their inventory, the images are updated in accordance with the current items they hold.
            ItemSlot1.sprite = Player.GetComponent<Inventory>()?.PlayerInventory[0].Image; 
            ItemSlot2.sprite = Player.GetComponent<Inventory>()?.PlayerInventory[1].Image;
            ItemSlot3.sprite = Player.GetComponent<Inventory>()?.PlayerInventory[2].Image;
            if (InventoryUI.activeSelf) // the same key stroke opens and closes the inventory
            { 
                InventoryUI.SetActive(false);
            }
            else
            {
                InventoryUI.SetActive(true);
            }
        }
        
        /// the number of the players slot can be pressed to drop an item.
        if (InventoryUI.activeSelf)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1) == true)
            {
                Inventory.Instance.RemoveItem(0);
            }
            if (Input.GetKeyDown(KeyCode.Alpha2) == true)
            {
                Inventory.Instance.RemoveItem(1);
            }
            if (Input.GetKeyDown(KeyCode.Alpha3) == true)
            {
                Inventory.Instance.RemoveItem(2);
            }
        }
    }
}
;