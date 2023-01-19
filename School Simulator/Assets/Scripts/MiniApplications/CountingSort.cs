using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class CountingSort : MonoBehaviour
{
    public string jumbledValues;
    public InputField PlayerInput;
    /// <summary>
    /// a function for sorting an array of integers in size order starting with the smallest. 
    /// </summary>
    
    //function to run the game on the in-game computer.
    public void RunGame()
    {
        Debug.Log("RUNNING GAME");
        Debug.Log(PlayerInput.text);

        if (AnswerCheck(CreateIntegerArray(PlayerInput.text), countingSort(CreateIntegerArray(jumbledValues))))
        {
            Debug.Log("CORRECT ANSWER");
            PlayerPrefs.SetInt("MoneyCounter", PlayerPrefs.GetInt("MoneyCounter") + 1);
        }
        else
        {
            Debug.Log("INCORRECT ANSWER");
        }
    }
    
    //function to take users input and create an integer array from it
    private int[] CreateIntegerArray(string input)
    {
        string[] numbers = input.Split(',');
        int[] integerArray = Array.ConvertAll(numbers, int.Parse);
        return integerArray;
    } 
    
    // function to check and output if the user inputed the right answer.
    private bool AnswerCheck(int[] userAnswer, int[] sortedArray)
    {
        return userAnswer.OrderBy(x => x).SequenceEqual(sortedArray.OrderBy(x => x));
    }
    
    //function that sorts the integer array
    private int[] countingSort(int[] inputArray) //takes in a jumbled array of integers
    {
        int[] frequencyArray = new int[(inputArray.Max() - inputArray.Min()) + 1]; // creates an array for the frequency of appearance of each value in the original array , with the length as the range of values.
        List<int> outputList = new List<int> { }; // creates a list that the ordered values will be printed into
        for(int i = 0; i + inputArray.Min() <= inputArray.Max(); i++) // for each number in the range of values in the array
        {
            frequencyArray[i] = inputArray.Count(n => n == (i + inputArray.Min()));
            for (int j = 0; j < frequencyArray[i]; j++) // for each value in the frequency array
            {
                outputList.Add(inputArray.Min() + 1); 
            }
        }
        return outputList.ToArray(); // converts the output list to an array and returns it.
    }
}
