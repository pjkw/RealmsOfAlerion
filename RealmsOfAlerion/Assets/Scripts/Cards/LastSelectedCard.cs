using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastSelectedCard : MonoBehaviour
{
    public static LastSelectedCard instance;

    // here we will keep all the data of the last selected card
    // that way we can have a modular approach
    // when we want to detect only the last selected card during a player turn,
    // we can:
    // 1) get the last selected card
    // 2) get the last selected card's data
    // 3) only update the last selected if the player is in a turn

    // this is the last selected card
    public GameObject lastSelectedCard;

    void Awake()
    {
        // singleton
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
