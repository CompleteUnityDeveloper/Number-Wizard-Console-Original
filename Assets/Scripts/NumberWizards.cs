using UnityEngine;
using System.Collections;

public class NumberWizards : MonoBehaviour {

	// Use this for initialization
	void Start () {
		print ("Welcome to Number Wizard");
		print ("Pick a number in your head, but don't tell me!");
		
		int max = 1000;
		int min = 1;
		
		print ("The highest number you can pick is " + max);
		print ("The lowest number you can pick it " + min);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
