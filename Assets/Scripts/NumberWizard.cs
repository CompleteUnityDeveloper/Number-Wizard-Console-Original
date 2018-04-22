using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour
{
    // configuration parameters
    [SerializeField] int lowestAllowed = 1;
    [SerializeField] int highestAllowed = 1000;

    // state variables
    int min;
    int max;
    int guess;
    int move;
	
	void Start ()
    {
        Debug.Assert(highestAllowed > lowestAllowed); // simple check
        StartGame();
	}
	
    // Update is called once per frame
    void Update()
    {
        RespondToKeys();
    }

	private void StartGame ()
    {
        ResetStateVariables();
        DisplayIntro(); // not order sensitive because of guess
    }

    private void ResetStateVariables()
    {
        min = lowestAllowed;
        max = highestAllowed + 1; // because Unity rounds-down
        guess = max / 2;
        move = 1;
    }

    private void DisplayIntro()
    {
        Debug.Log("========================");
        Debug.Log("Welcome to Number Wizard");
        Debug.Log("Pick a number in your head, but don't tell me!");

        Debug.Log("The highest number you can pick is " + max);
        Debug.Log("The lowest number you can pick is " + min);

        Debug.Log("Is the number higher or lower than " + guess + "?");
        Debug.Log("Up = higher, down = lower, return = equal");
    }

    private void RespondToKeys()
    {
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
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I guessed your number in this many moves: " + move);
            StartGame();
        }
    }

    private void NextGuess ()
    {
        guess = (max + min) / 2;
        Debug.Log ("Higher or lower than " + guess);
        move++;
	}
}