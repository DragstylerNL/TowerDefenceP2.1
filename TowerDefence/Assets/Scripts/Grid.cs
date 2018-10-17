using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour {

    private Tile[,] grid;
    
	void Start () {
		for(int i = 0; i < 5; i++) { for(int j = 0; j < 15; j++)
            {
                grid[i, j] = new Tile();
                grid[i, j].y = i;
                grid[i, j].x = j;
        } }
	}

    public void Test() { print("Test: Grid"); }

    public int[] GetSize()
    {
        int[] gridSize = new int[2];
        gridSize[0] = grid.GetLength(0);
        gridSize[1] = grid.GetLength(1);
        return gridSize;
    }

    public string GetTile(int x, int y)
    {
        return grid[y, x].ententy;
    }

    public void SetTile(int x, int y, string ententy)
    {
        grid[y, x].ententy = ententy;
    }
}
