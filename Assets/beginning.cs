using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class how : MonoBehaviour
{
    /*
                                        // Exe 1
    void Start()
    {
        int huntCount = 0; 
        int escapeNumber = 15; 
        int ghostNumber = 5; 

        Debug.Log("The hunt begins .. I hope the ghost doesn't come");
        while (true)
        {
            int huntedNumber = Random.Range(1, 21);
            huntCount++;
            if (huntedNumber == ghostNumber){
                Debug.Log("The hunter spotted a ghost number and decided to move silently ! ");
                continue; 
            }
            Debug.Log("Hunter caught: " + huntedNumber + " on attempt #" + huntCount);
            if (huntedNumber == escapeNumber)
            {
                Debug.Log("The hunter faced the Great Beast (15) and fled the forest after " + huntCount + " attempts.");
                break; 
            }
        }

    }   
*/

                              //Exe 2 
         string[] words = {"Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird" };
    string sentence = "";

    void Start()
    {
        int count = 0;
        string[] selectedWords = new string[7];

        while (count < 7){
            int randomIndex = Random.Range(0, words.Length);
            selectedWords[count] = words[randomIndex];
            count++;
        }

        sentence = "A " + selectedWords[0] + " and a " + selectedWords[1] +
         " drove a " + selectedWords[2] + " to find a " + selectedWords[3] +
         " that sings like a " + selectedWords[4] + ", while wearing a " +
         selectedWords[5] + " on a " + selectedWords[6] + "!";

        Debug.Log(sentence);
    }
}