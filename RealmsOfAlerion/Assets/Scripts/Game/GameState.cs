using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{
    // player turn enum
    public enum PlayerTurn
    {
        Player1,
        Player2,
        Player3,
        Player4,
        Player5
    }

    public PlayerTurn playerTurn;

    // game phase enum
    public enum GamePhase
    {
        None,
        Buy,
        Build,
        GameOver
    }

    public GamePhase gamePhase;
}
