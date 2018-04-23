using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsoleDisplay : MonoBehaviour
{
	// configuration parameters
    [SerializeField] int lowestAllowed = 1;
    [SerializeField] int highestAllowed = 1000;

    // state variables

    // references to other objects
    NumberWizard numberWizard;

    void Start()
    {
        Debug.Assert(highestAllowed > lowestAllowed); // simple check
        numberWizard = new NumberWizard(lowestAllowed, highestAllowed);
        DisplayIntro();
    }

    void Update()
    {
        RespondToKeys();
    }

    private void DisplayIntro()
    {
        Debug.Log("========================");
        Debug.Log("Welcome to Number Wizard");
        Debug.Log("Pick a number in your head, but don't tell me!");

        Debug.Log("Pick a number between " + lowestAllowed + " and " + highestAllowed);

        var initialGuess = numberWizard.GetGuess();
        Debug.Log("Is the number higher or lower than " + initialGuess + "?");
        Debug.Log("Up = higher, down = lower, return = equal");
    }

    private void RespondToKeys()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            numberWizard.GetHigherGuess();
            var newGuess = numberWizard.GetGuess();
            Debug.Log("Higher or lower than " + newGuess);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            numberWizard.GetLowerGuess();
            var newGuess = numberWizard.GetGuess();
            Debug.Log("Higher or lower than " + newGuess);
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I guessed your number!");
            Start();
        }
    }
}
