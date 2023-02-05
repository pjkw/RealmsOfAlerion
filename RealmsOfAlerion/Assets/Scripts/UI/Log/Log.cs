using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Log : MonoBehaviour
{
    public Text log;
    public Text gamePhase;
    public Text playerTurn;
    public Text tutorial;

    void Update()
    {
        LogData();
    }

    public void LogMessage(string message)
    {
        log.text = message;
    }

    public void LogGamePhase(string message)
    {
        gamePhase.text = message;
    }

    public void LogPlayerTurn(string message)
    {
        playerTurn.text = message;
    }

    public void LogTutorial(string message)
    {
        tutorial.text = message;
    }
    
    void LogData()
    {
        // log game phase
        LogGamePhase("Game Phase: " + GameState.instance.gamePhase);

        // log player turn
        LogPlayerTurn("Player Turn: " + GameState.instance.playerTurn);
    }
}