using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    public static Map instance;

    public int width = 10;
    public int height = 10;

    public float hexSize;

    float verticalDistance;
    float horizontalDistance;

    public GameObject tilePrefab;

    // these are the tiles we will build with
    public GameObject villageTile;
    GameObject currentGameObject;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        // In the pointy top orientation, the horizontal distance between adjacent hexagon centers is horiz = width = sqrt(3) * size.
        // The vertical distance is vert == 3/4 * height == 3/2 * size.

        horizontalDistance = Mathf.Sqrt(3) * hexSize;
        // this is the final value we were adjusting
        // we were decreasing this down from 1.4 to get the narrow y spacing
        verticalDistance = hexSize * 1.36f; // hexSize; // 1.4f; // 3 / 2 * hexSize; // okay this works, but we need a custom multiplier for now here

        GenerateMap();
    }

    void GenerateMap()
    {
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                if (y % 2 == 0)
                {
                    GameObject tile = Instantiate(tilePrefab, new Vector3(x * horizontalDistance, y * verticalDistance, 0), Quaternion.identity, this.transform);
                    TileData tileData = tile.GetComponent<TileData>();
                    tileData.coordinates = new Vector2Int(x, y);
                }
                else
                {
                    GameObject tile = Instantiate(tilePrefab, new Vector3(x * horizontalDistance + horizontalDistance / 2, y * verticalDistance, 0), Quaternion.identity, this.transform);
                    TileData tileData = tile.GetComponent<TileData>();
                    tileData.coordinates = new Vector2Int(x, y);
                }
            }
        }

        // set size after done, since is affected by parent

        SetSize();
    }

    void SetSize()
    {
        this.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
    }

    public GameObject SpawnTile(TileData.TileType tileType)
    {
        if (tileType == TileData.TileType.Village)
        {
            // set the z coordinate of this tile to -1 so we show the tile on top top
            // in the future if we want to spawn a marker on this tile,
            // such as what level this structure is,
            // then we would decrement the z by one, so -2

            currentGameObject = Instantiate(villageTile, new Vector3(0, 0, -1), Quaternion.identity, this.transform);
            
            return currentGameObject;
        }

        return null;
    }
}