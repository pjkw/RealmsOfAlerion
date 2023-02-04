using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TileData : MonoBehaviour
{
    public TextMeshProUGUI text;

    private Vector2Int _coordinates;

    public Vector2Int coordinates 
    { 
        get { return _coordinates; } 
        set { 
            _coordinates = value; 
            SetTextCoordinates(); 
        } 
    }

    public enum TileType
    {
        Grass,
        Water,
        Mountain,
        Forest,
        Desert
    }

    public TileType tileType;

    void Start()
    {
        SetTextCoordinates();
    }

    void SetTextCoordinates()
    {
        text.text = coordinates.ToString();
    }
}