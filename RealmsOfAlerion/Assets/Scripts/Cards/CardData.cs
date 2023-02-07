using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    public enum ResourceCostType
    {
        None,
        Gold,
        Wood,
        Food
    }

    [SerializeField] public ResourceCostType resourceCostType1;
    [SerializeField] public ResourceCostType resourceCostType2;
    [SerializeField] public ResourceCostType resourceCostType3;

    [System.Serializable]
    public enum ResourceOutputType
    {
        None,
        Gold,
        Wood,
        Food
    }

    [SerializeField] public ResourceOutputType resourceOutputType1;
    [SerializeField] public ResourceOutputType resourceOutputType2;
    [SerializeField] public ResourceOutputType resourceOutputType3;

    [SerializeField] public int resourceCost1;
    [SerializeField] public int resourceCost2;
    [SerializeField] public int resourceCost3;
    [SerializeField] public int resourceOutput1;
    [SerializeField] public int resourceOutput2;
    [SerializeField] public int resourceOutput3;
}