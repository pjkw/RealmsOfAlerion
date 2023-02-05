using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardData : MonoBehaviour
{
    // enum card type
    public enum CardType
    {
        None,
        Unit,
        Spell,
        Building
    }

    public CardType cardType;

    public enum BuildingType
    {
        None,
        TownHall,
        Barracks,
        Farm,
        Village,
        Mine,
        LumberMill,
        Tower,
        Wall
    }

    public BuildingType buildingType;

    public enum ResourceType
    {
        None,
        Gold,
        Wood,
        Food
    }
    
    public ResourceType resourceType;

    public enum ResourceCount
    {
        None,
        One,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten
    }

    public ResourceCount resourceCount;
}