using UnityEngine;
using DentedPixel;

public class MoveCardOnPurchase : MonoBehaviour
{
    [SerializeField] float speed = 0.5f;
    [SerializeField] float delay = 0.25f;

    public Transform[] cardPositions;
    public GameObject[] cards;
    public AudioSource audioSource;

    public void MovePurchasedCardToTableauArea()
    {
        for (int i = 0; i < cards.Length; i++)
        {
            int index = i;
            LeanTween.move(cards[index], cardPositions[index].position, speed).setEase(LeanTweenType.easeInQuad);
        }
    }

    void PlaySound()
    {
        audioSource.Play();
    }
}