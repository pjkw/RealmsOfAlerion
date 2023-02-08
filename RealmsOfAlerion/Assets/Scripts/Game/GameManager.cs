using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject player;
    [SerializeField] DealCards dealCards;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        // we can call this from the menu later

        StartNewGame();
    }

    void StartNewGame()
    {
        GameState.instance.playerTurn = GameState.PlayerTurn.Player1;
        GameState.instance.gamePhase = GameState.GamePhase.DealCards;

        dealCards.Deal();

        // after we deal the cards, we advance the game phase to the buy phase
        // we have just one general buy phase for both players,
        // any specific player actions can be determined with PlayerTurn.Player1 or PlayerTurn.Player2
        
        GameState.instance.gamePhase = GameState.GamePhase.Buy;
    }

    // allow player to select a card on GameState.GamePhase.Buy
}