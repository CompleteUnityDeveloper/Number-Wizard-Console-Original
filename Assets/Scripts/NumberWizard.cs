using UnityEngine;

public class NumberWizard
{
    // state variables
    private int min;
    private int max;
    private int guess;

    public NumberWizard(int lowestAllowed, int highestAllowed) // constructor
    {
        min = lowestAllowed;
        max = highestAllowed + 1; // because of rounding-down
        guess = max / 2;
    }

    public int GetGuess()
    {
        return guess;
    }

    public void GuessHigher()
    {
        min = guess;
        guess = (max + min) / 2;
    }

    public void GuessLower()
    {
        max = guess;
        guess = (max + min) / 2;
    }
}