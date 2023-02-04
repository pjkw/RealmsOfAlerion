using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickTile : MonoBehaviour
{
    Log log;

    void Awake()
    {
        log = FindObjectOfType<Log>();
    }

    public void OnMouseDown()
    {
        // for now let's return data here, but in the future,
        // this should be separated out from here
        // or perhaps we use this as an always on global method to update
        // the last clicked on tile

        // get the tile data
        TileData tileData = GetComponent<TileData>();

        // get the coordinates
        Vector2Int coordinates = tileData.coordinates;

        // output tile data and coordinates to log
        log.LogMessage("Tile Type: " + tileData.tileType + " Coordinates: " + coordinates);
    }
}