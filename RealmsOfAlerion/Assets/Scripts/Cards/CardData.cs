using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ResourceCost
{
    public ResourceCostType resourceType;
    public int cost;
}

public enum ResourceCostType
{
    None,
    Food,
    Wood,
    Magic,
    Mana,
    Gold
}

public class CardData : MonoBehaviour
{
    [System.Serializable]
    public enum CardType
    {
        None,
        Unit,
        Spell,
        Building
    }

    [SerializeField] public CardType cardType;

    [System.Serializable]
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
    
    [SerializeField] public BuildingType buildingType;

    public List<ResourceCost> resourceCost = new List<ResourceCost>();

    public enum ResourceCostType
    {
        None,
        Food,
        Wood,
        Magic,
        Mana,
        Gold
    }
}