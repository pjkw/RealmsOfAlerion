using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public static Inventory instance;

    [System.Serializable]
    public class Resources
    {
        public int food;
        public int wood;
        public int magic;
        public int mana;
        public int gold;
    }

    [Header("Resources")]
    public Resources player1Resources;
    public Resources player2Resources;

    // add label in inspector -- Cards in Hand

    [System.Serializable]
    public class UnactivatedCards
    {
        public List<GameObject> cards;
    }

    [Header("Cards In Hand")]
    public UnactivatedCards player1UnactivatedCards;
    public UnactivatedCards player2UnactivatedCards;

    
    [System.Serializable]
    public class ActivatedCards
    {
        public List<GameObject> cards;
    }

    [Header("Purchased Cards")]
    public ActivatedCards player1ActivatedCards;
    public ActivatedCards player2ActivatedCards;

    
    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        SetStartingResources();
    }

    void SetStartingResources()
    {
        player1Resources.food = 1;
        player1Resources.wood = 1;
        player1Resources.magic = 1;
        player1Resources.mana = 1;
        player1Resources.gold = 1;

        player2Resources.food = 1;
        player2Resources.wood = 1;
        player2Resources.magic = 1;
        player2Resources.mana = 1;
        player2Resources.gold = 1;
    }
}