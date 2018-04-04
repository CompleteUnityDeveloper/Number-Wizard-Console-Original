using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        print("Welcome to Number Wizard");
        print("Pick a number, but don't tell me!");

        // 
        int min = 1; // This declaration has been instantiated: An interger variable, named minimum, set to a value of 1.
        int max = 1000; //Challenge: to declare and instantiate maximum variable

        //We combine strings with our new variable, note it is combining a string and interger together for us.
        print("The highest number you can pick is " + max); //example statment
        print("The lowest number you can pick it " + min);  //challenge statement

    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
