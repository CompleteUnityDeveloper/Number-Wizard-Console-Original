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
        //Example: Check what the user has pressed... if up, print to console "Up"
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            print("Up arrow pressed");
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            print("Down arrow pressed");
        }

        else if(Input.GetKeyDown(KeyCode.Return))
        {
                print("I won!");
        }    
    }
}
