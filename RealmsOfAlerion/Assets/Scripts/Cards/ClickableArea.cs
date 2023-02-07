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

        CardData cardDate = GetComponentInParent<CardData>();

        Debug.Log(cardDate.cardType);
        Debug.Log(cardDate.buildingType);

        audioManager.PlaySelectCard();

        // LastSelectedCard.instance.lastSelectedCard = gameObject;
    
        // assign last selected card to the parent object of this object
        LastSelectedCard.instance.lastSelectedCard = gameObject.transform.parent.gameObject;
    }

    // Detect if clicks are no longer registering
    public void OnPointerUp(PointerEventData pointerEventData)
    {
        // Debug.Log(name + "No longer being clicked");
    }
}