using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public static Inventory instance;

    [SerializeField] InventoryBar inventoryBar;

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

    [SerializeField] MoveCardOnPurchase moveCardOnPurchase;

    
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


    public bool HasEnoughResources(int playerNumber, Dictionary<ResourceCostType, int> resourceCost)
    {
        Resources resources;

        if (playerNumber == 1)
        {
            resources = player1Resources;
        }
        else
        {
            resources = player2Resources;
        }

        foreach (KeyValuePair<ResourceCostType, int> cost in resourceCost)
        {
            switch (cost.Key)
            {
                case ResourceCostType.Food:
                    if (resources.food < cost.Value)
                    {
                        return false;
                    }
                    break;
                case ResourceCostType.Wood:
                    if (resources.wood < cost.Value)
                    {
                        return false;
                    }
                    break;
                case ResourceCostType.Magic:
                    if (resources.magic < cost.Value)
                    {
                        return false;
                    }
                    break;
                case ResourceCostType.Mana:
                    if (resources.mana < cost.Value)
                    {
                        return false;
                    }
                    break;
                case ResourceCostType.Gold:
                    if (resources.gold < cost.Value)
                    {
                        return false;
                    }
                    break;
                default:
                    break;
            }
        }

        return true;
    }

    public bool CheckPlayerResources(CardData cardData)
    {
        // Get the player's resources from the Inventory instance
        Inventory.Resources playerResources = player1Resources;

        // Check if the player has enough of each resource required for the card
        foreach (ResourceCost resourceCost in cardData.resourceCost)
        {
            switch (resourceCost.resourceType)
            {
                case ResourceCostType.Food:
                    if (playerResources.food < resourceCost.cost)
                    {
                        return false;
                    }
                    break;
                case ResourceCostType.Wood:
                    if (playerResources.wood < resourceCost.cost)
                    {
                        return false;
                    }
                    break;
                case ResourceCostType.Magic:
                    if (playerResources.magic < resourceCost.cost)
                    {
                        return false;
                    }
                    break;
                case ResourceCostType.Mana:
                    if (playerResources.mana < resourceCost.cost)
                    {
                        return false;
                    }
                    break;
                case ResourceCostType.Gold:
                    if (playerResources.gold < resourceCost.cost)
                    {
                        return false;
                    }
                    break;
            }
        }

        // If the player has enough of each resource required for the card, return true
        return true;
    }

    public void PurchaseCard(GameObject go, CardData cardData)
    {
        
        // If the player has enough resources, subtract the cost from the player's resources
        foreach (ResourceCost resourceCost in cardData.resourceCost)
        {
            switch (resourceCost.resourceType)
            {
                case ResourceCostType.Food:
                    player1Resources.food -= resourceCost.cost;
                    break;
                case ResourceCostType.Wood:
                    player1Resources.wood -= resourceCost.cost;
                    break;
                case ResourceCostType.Magic:
                    player1Resources.magic -= resourceCost.cost;
                    break;
                case ResourceCostType.Mana:
                    player1Resources.mana -= resourceCost.cost;
                    break;
                case ResourceCostType.Gold:
                    player1Resources.gold -= resourceCost.cost;
                    break;
            }
        }

        inventoryBar.UpdateText();

        // Add the card to the player's activated cards
        player1ActivatedCards.cards.Add(go);

        // Remove the card from the player's unactivated cards
        // TODO: we will need to add the dealt cards to the
        // player1UnactivatedCards.cards.Remove(go);


        // move card down into the tableau area

        // moveCardOnPurchase.MovePurchasedCardToTableauArea();
    }
}

/*
int playerNumber = 1; // For example purposes, let's say this is player 1

        // Create a dictionary with the resource type and cost
        Dictionary<ResourceCostType, int> resourceCost = new Dictionary<ResourceCostType, int>();
        resourceCost.Add(ResourceCostType.Wood, 1);

        // Call the HasEnoughResources method to check if the player has enough resources
        bool hasEnoughResources = Inventory.instance.HasEnoughResources(playerNumber, resourceCost);

        // Output the result
        if (hasEnoughResources)
        {
            Debug.Log("Player has enough resources");
        }
        else
        {
            Debug.Log("Player does not have enough resources");
        }
*/

