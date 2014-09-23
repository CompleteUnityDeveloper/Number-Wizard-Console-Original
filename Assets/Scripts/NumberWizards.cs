using UnityEngine;
using System.Collections;

public class NumberWizards : MonoBehaviour {
	// Use this for initialization
	int max = 1000;
	int min = 1;
	int guess = 500;
	
	void Start () {
		max = max + 1;
		
		print ("Welcome to Number Wizard");
		print ("Pick a number in your head, but don't tell me!");
		
		print ("The highest number you can pick is " + max);
		print ("The lowest number you can pick it " + min);
		
		print ("Is the number higher or lower than " + guess);
		print ("Up = higher, down = lower, return = equal");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			min = guess;
			guess = (max + min) / 2;
			print ("Higher or lower than " + guess);
		} else if (Input.GetKeyDown(KeyCode.DownArrow)) {
			max = guess;
			guess = (max + min) / 2;
			print ("Higher or lower than " + guess);
		} else if (Input.GetKeyDown(KeyCode.Return)) {
			print("I won!");
		}
	}
}
