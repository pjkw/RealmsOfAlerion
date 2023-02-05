using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    [SerializeField] Log log;

    // make a list for the intro tutorial messages
    List<string> introTutorialMessages = new List<string>();

    // current list index
    int currentListIndex = 0;

    void Start()
    {
        Load();

        ShowFirstMessage();
    }

    void Update()
    {
        OnAnyKeyPress();
    }

    void Load()
    {
        PopulateIntroTutorialMessages();
    }

    // populate the list
    void PopulateIntroTutorialMessages()
    {
        introTutorialMessages.Add("Welcome to the tutorial! Press any key to advance through the tutorial.");
        
        // in the future we can show an arrow pointing to what the tutorial is referring to
        // also todo, investigate how to position the tutorial elements
        // we will also change the width of the background tutorial panel,
        // based on the number of characters in each log message

        introTutorialMessages.Add("This is also the log. It will display messages to you throughout the game.");
        introTutorialMessages.Add("This is the game phase. It will tell you what phase of the game you are in.");
        // add log message for telling the player the player turn is the player
        introTutorialMessages.Add("This is the player turn. It will tell you whose turn it is.");
        introTutorialMessages.Add("This is the player's money. It will tell you how much money you have.");

        // add log message for resources count, including wood and food
        introTutorialMessages.Add("This is the player's resources. It will tell you how many resources you have.");

        // add log for wood and food count
        introTutorialMessages.Add("This is the player's wood. It will tell you how much wood you have.");

        introTutorialMessages.Add("This is the player's food. It will tell you how much food you have.");
    
        // add log message for explainign victory points on each side of the track
        introTutorialMessages.Add("This is the player's victory points. It will tell you how many victory points you have.");

        // add log message for explaining the opponent's victory points
        introTutorialMessages.Add("This is the opponent's victory points. It will tell you how many victory points your opponent has.");
    
        // add log for: there are different ways of scoring victory points
        introTutorialMessages.Add("There are different ways of scoring victory points. You can score them by building buildings, or by having the most victory points at the end of the game.");        
    }

    // log tutorial
    public void LogTutorial(string message)
    {
        log.LogTutorial(message);
    }

    void ShowFirstMessage()
    {
        LogTutorial("Welcome to the tutorial! Press any key to continue.");
    }

    void OnAnyKeyPress()
    {
        if (Input.anyKeyDown)
        {
            currentListIndex++;

            if (currentListIndex < introTutorialMessages.Count)
            {
                LogTutorial(introTutorialMessages[currentListIndex]);
            }   
        }
    }
}