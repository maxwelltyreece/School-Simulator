using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VendingMachine_Manager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Interaction()
    {

    }


}

//class vendingMachine : Queue<Item>
//{
//    Random rand = new Random();
//    private Item[] possibleItems;
//    private int sizeOfMachine;

//    public vendingMachine(Item[] Items, int Size)
//    {
//        possibleItems = Items;
//        sizeOfMachine = Size;
//    }

//    public void stockMachine()
//    {
//        for (int i = 0; i < sizeOfMachine; i++)
//        {
//            this.Shuffle<Item>(possibleItems);
//        }

//    }

//    public void stockMachine(int MachineSize)
//    {
//        base.Clear();
//        for (int i = 0; i < MachineSize; i++)
//        {
//            this.Shuffle<string>(possibleItems);
//        }

//    }

//    public void WhatsInTheMachine()
//    {
//        int counter = base.Count;
//        for (int i = 0; i < counter; i++)
//        {
//            string current = base.Peek();
//            Console.WriteLine(base.Dequeue());
//            base.Enqueue(current);
//        }

//    }

//    public void Shuffle<T>(string[] list)
//    {
//        int length = list.Length;
//        while (length > 1)
//        {
//            length--;
//            int k = rand.Next(length + 1);
//            string value = list[k];
//            list[k] = list[length];
//            list[length] = value;
//        }
//    }
//}
