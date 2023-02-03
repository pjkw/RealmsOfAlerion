using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class TileData : MonoBehaviour
{
    public Vector2Int coordinates;

    public TextMeshProUGUI text;

    void Start()
    {
        SetTextCoordinates();
    }

    void SetTextCoordinates()
    {
        text.text = coordinates.ToString();
    }
}