using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Moving these variables out of the Start Method, means we can use them again in the update and other methods too.
    // We have broadened their scope.
    int min = 1; 
    int max = 1000; 
    int guess = 500;
    //int max 1001; explain why this is not the solution

    // Use this for initialization
    void Start()
    {
        print("Welcome to Number Wizard");
        print("Pick a number, but don't tell me!");

        // 

        //We combine strings with our new variable, note it is combining a string and interger together for us.
        print("The highest number you can pick is " + max); //example statment
        print("The lowest number you can pick it " + min);  //challenge statement

        print("Is the number higher or lower than " + guess + "?"); // Ask question
        print("Up = higher, down = lower, return = equal"); // Tell user what to do

    }

    // Update is called once per frame
    void Update()
    {

        max = 1001; //challenge bug fix
        //max = max + 1; Explain why this isn't a solution
        //Example: Check what the user has pressed... if up, print to console "Up"
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
             
            //print("Up arrow pressed");
            //Instruction
            min = guess;
            guess = (max + min) / 2;
            print("Higher or lower than " + guess);
            //Can you find and Fix the 999 bug?
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            //print("Down arrow pressed");
            //Challenge
            max = guess;
            guess = (max + min) / 2;
            print("Higher or lower than " + guess);
        }

        else if(Input.GetKeyDown(KeyCode.Return))
        {
                print("I won!");
        }    
    }
}
