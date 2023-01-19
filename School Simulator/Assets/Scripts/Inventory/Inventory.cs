using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// This code ecompases the player's inventory, functions allowing them to add and remove items 
/// from their inventory, as well as organising it to ensure the inventory UI has no gaps in it.
/// </summary>
public class Inventory : MonoBehaviour
{
    public List<Item> PlayerInventory; // the players inventory is a list of objects, 'Item' being a class made prior.
    [SerializeField] Conversation InventoryFUllMessage; // error messages needed to display to the user.
    public Conversation DuplicateItemMessage;
    [SerializeField] public Item Blank; // to prevent errors involving unity constant updates regarding null references, an item of 'blank'
                                        // type is fed into the list.
    
    // A static instance of the inventory within it's own class is needed to reference it in other classes.
    // As there is only one inventory in the game, the instance is static.
    public static Inventory Instance { get; private set; }
    void Start() // prefents new instances being created when new scenes are entered, and fills the inventory with blank items
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            PlayerInventory[0] = Blank;
            PlayerInventory[1] = Blank;
            PlayerInventory[2] = Blank;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    
    public bool AddItem(Item item) // function to add an item to the players inventory.
    {
        for( int i = 0; i < 3; i++)
        {
            if (PlayerInventory[i] == null || PlayerInventory[i] == Blank)
            {
                PlayerInventory[i] = item;
                return true;
            }
            if (PlayerInventory[i] == item)
            {
                Debug.Log("YOU ALREADY HAVE THIS ITEM!");
                Dialogue.Instance.StartConversation(DuplicateItemMessage);
                return false;
            }
            if (i == 2)
            {
                Debug.Log("INVENTORY IS FULL");
            }
        }
        return false;
    }

    public void RemoveItem(int Inventory_Position) // function to remove item from the users inventory
    {
        Debug.Log("REMOVE ITEM BUTTON");
        Instance.PlayerInventory[Inventory_Position] = Blank;
        organiseInventory();
    }
    
    public void RemoveItem(Item Item_to_Remove)
    {
        Debug.Log("ITEM REMOVED");
        for (int i = 0; i < 3; i++)
        {
            if (PlayerInventory[i] == Item_to_Remove)
            {
                PlayerInventory[i] = Blank;
                break;
            }
        }
        organiseInventory();
    }

    public bool ItemCheck(Item checkItem)
    {
        foreach(Item i in PlayerInventory)
        {
            if( i == checkItem)
            {
                return true;
            }
        }
        
        return false;
    }

    public bool ItemCheckMultiple(Item checkItem, int numberOfItems)
    {
        int check = 0;
        foreach(Item i in PlayerInventory)
        {
            if (i == checkItem)
            {
                check++;
            }
        }
        if(check == numberOfItems)
        {
            return true;
        }
        return false;
    }

    private void organiseInventory() // function to organise the items in the inventory to remove blank spaces so when viewing in the UI 
    {                                // items are pushed to the left.
        if (PlayerInventory[0] == null || PlayerInventory[0] == Blank)
        {
            PlayerInventory[0] = PlayerInventory[1];
            PlayerInventory[1] = Blank;
        }
        if (PlayerInventory[1] == null || PlayerInventory[1] == Blank)
        {
            PlayerInventory[1] = PlayerInventory[2];
            PlayerInventory[2] = Blank;
        }
    }
}
