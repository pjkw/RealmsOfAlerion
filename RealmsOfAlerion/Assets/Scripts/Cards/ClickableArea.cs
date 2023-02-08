// attach to game object to be clicked

using UnityEngine;
using UnityEngine.EventSystems;

public class ClickableArea : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    // Detect current clicks on the GameObject (the one with the script attached)

    [SerializeField] AudioManager audioManager;

    public void OnPointerDown(PointerEventData pointerEventData)
    {
        // Output the name of the GameObject that is being clicked
        // Debug.Log(name + "Game Object Click in Progress");

        CardData cardData = GetComponentInParent<CardData>();

        audioManager.PlaySelectCard();

        // LastSelectedCard.instance.lastSelectedCard = gameObject;
    
        // assign last selected card to the parent object of this object
        LastSelectedCard.instance.lastSelectedCard = gameObject.transform.parent.gameObject;

        // Check if the player has enough resources to purchase the card

        bool canPurchase = Inventory.instance.CheckPlayerResources(cardData);

        if (canPurchase)
        {
            Debug.Log("Player has enough resources to purchase the card");
        }

        else
        {
            Debug.Log("Player does not have enough resources to purchase the card");
        }
    }

    // Detect if clicks are no longer registering
    public void OnPointerUp(PointerEventData pointerEventData)
    {
        // Debug.Log(name + "No longer being clicked");
    }
}