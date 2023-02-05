using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource selectCard;

    public void PlaySelectCard()
    {
        Debug.Log("PlaySelectCard");
        selectCard.Play();
    }
}
