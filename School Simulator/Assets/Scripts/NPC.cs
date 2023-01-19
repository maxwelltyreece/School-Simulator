using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// class for all NPC functionality
/// </summary>
public class NPC : MonoBehaviour, Interaction_Interface
{
    [SerializeField] private Conversation NPC_Lines;
    [SerializeField] private Conversation Success_Message;

    public enum NPCType { Collection,Talk};
    public NPCType type;
    public enum Misison { M1,M2,M3,M4,M5}
    public Misison NPC_Mission;
    [SerializeField] private Item item_To_Check;
    [SerializeField] private int reward;

    public void Interaction()
    {
        Debug.Log("This is interacting with the npc");
        switch (type)
        {
            case NPCType.Collection:

                if (Inventory.Instance.ItemCheck(item_To_Check))
                {
                    Debug.Log("ITEM FOUND");
                    Inventory.Instance.RemoveItem(item_To_Check);
                    Dialogue.Instance.StartConversation(Success_Message);
                    PlayerPrefs.SetInt(NPC_Mission.ToString(), 1);
                    PlayerPrefs.SetInt("MoneyCounter", PlayerPrefs.GetInt("MoneyCounter")+reward);
                    break;
                }
                else
                {
                    PlayerPrefs.SetInt("Frozen", 0);
                    Dialogue.Instance.StartConversation(NPC_Lines);
                    break;
                }

            case NPCType.Talk:
                PlayerPrefs.SetInt("Frozen", 0);
                Dialogue.Instance.StartConversation(NPC_Lines);
                break;
        }
        
    }
}
