using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour {

    public GameObject prefabTile;
    private float placementScaleX = 1.3f;
    private float placementScaleY = 1.1f;
    private int sizeX = 13, sizeY = 5;

    private GameObject[,] gridObjects;
    private Tile[,] gridTiles;

    void Start () {
        gridObjects = new GameObject[sizeY, sizeX];
        gridTiles = new Tile[sizeY, sizeX];

        for (int i = 0; i < sizeY; i++) { for(int j = 0; j < sizeX; j++)
            {
                gridObjects[i, j] = Instantiate(prefabTile);
                gridTiles[i, j] = gridObjects[i, j].GetComponent<Tile>();
                gridTiles[i, j].y = i;
                gridTiles[i, j].x = j;
                float posX = GetWorldPos(j, i)[0];
                float posY = GetWorldPos(j, i)[1];
                if (i != Mathf.FloorToInt(i / 2)* 2) { posX -= placementScaleX / 2; }
                gridObjects[i, j].transform.position = new Vector3(posX, posY, 0);
        } }
	}

    public void Test() { print("Test: Grid"); }

    public int[] GetSize()
    {
        int[] gridSize = new int[2];
        gridSize[0] = gridTiles.GetLength(0);
        gridSize[1] = gridTiles.GetLength(1);
        return gridSize;
    }

    public string GetTileEnt(int x, int y)
    {
        return gridTiles[y, x].entity;
    }

    public void SetTileEnt(int x, int y, string entity)
    {
        gridTiles[y, x].entity = entity;
    }

    public float[] GetWorldPos(int x, int y)
    {
        float[] returnHolder= new float[2];
        returnHolder[0] = (gridTiles[y, x].x - Mathf.FloorToInt(gridTiles.GetLength(1) / 2))* placementScaleX;
        returnHolder[1] = (gridTiles[y, x].y - Mathf.FloorToInt(gridTiles.GetLength(0) / 2))* placementScaleY;
        return returnHolder;    
    }
}
