using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int min; 
    int max; 
    int guess;

    // Use this for initialization
    void Start()
    {
        StartGame();
    }

    // Simplifying game start Instruction
    void StartGame()
    {
        min = 1;
        max = 1000;
        guess = 500;

        print("Welcome to Number Wizard");
        print("Pick a number, but don't tell me!");
        
        print("The highest number you can pick is " + max);
        print("The lowest number you can pick it " + min);

        print("Is the number higher or lower than " + guess + "?");
        print("Up = higher, down = lower, return = equal");
    }

    // Update is called once per frame
    void Update()
    {

        max = 1001;
        //Challenge Refactor
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
        }
       
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        }

        else if(Input.GetKeyDown(KeyCode.Return))
        {
                print("I won!");
        }    
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        print("Higher or lower than " + guess);
    }
}
