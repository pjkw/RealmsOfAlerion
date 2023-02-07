using UnityEngine;
using DentedPixel;

public class DealCards : MonoBehaviour
{
    public Transform[] cardPositions;
    public GameObject[] cards;

    void Start()
    {
        for (int i = 0; i < cards.Length; i++)
        {
            // LeanTween.scale( avatarScale, new Vector3(1.7f, 1.7f, 1.7f), 5f).setEase(LeanTweenType.easeOutBounce);
            int index = i;
            LeanTween.move(cards[index], cardPositions[index].position, 1f).setEase(LeanTweenType.easeInQuad).setDelay(i * 0.5f);
        }
    }
}
