using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {

	// Game state
	int level; 
	enum Screen {MainMenu, Password, Win, Lose};
	Screen currentScreen;

	// Use this for initialization
	void Start () {
		ShowMainMenu(greeting);
		
	}

	void OnUserInput(string input) {
		if (input.ToUpper() == "MENU") {
			ShowMainMenu(welcomeBack);
		} else if (currentScreen == Screen.MainMenu) {
			RunMainMenu(input);
		}
		// Terminal.WriteLine("The user wrote " + input);
	}

	void RunMainMenu(string input) {
		if (input == "1") {
			level = 1;
			StartGame();
		} else if (input == "2") {
			level = 2;
			StartGame();
		} else if (input == "3") {
			level = 3;
			StartGame();
		} else {
			Terminal.WriteLine("Please choose a valid level.");
		}
	}

	string greeting = "Welcome duder!";

	string welcomeBack = "Welcome back duder!";

	void ShowMainMenu(string greeting) {
		currentScreen = Screen.MainMenu;
		Terminal.ClearScreen();
		Terminal.WriteLine(greeting);
		Terminal.WriteLine("What do you want to hack?");
		Terminal.WriteLine("Press 1 for the Library");
		Terminal.WriteLine("Press 2 for the FBI");
		Terminal.WriteLine("Press 3 for the Pentagon");
		Terminal.WriteLine("Enter your choice: ");
	}
	
	void StartGame() {
		currentScreen = Screen.Password;
		Terminal.WriteLine("You have logged on to the Library");
		Terminal.WriteLine("Please enter your password: ");
		
	}
	// Update is called once per frame
	void Update () {
		
	}
}
