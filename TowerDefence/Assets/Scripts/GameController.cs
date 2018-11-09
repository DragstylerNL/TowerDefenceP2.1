using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public Grid grid;
    
    private int[] SelectedPos = new int[2];
    
	void Start () {
    Select();
    }

    void Update () {

    }

    public int[] GetSelectedPos()
    {
        return SelectedPos;
    }

    public void SetSelectedX(int xMov) { DeSelect(); SelectedPos[0] += xMov; Select(); }
    public void SetSelectedY(int yMov) { DeSelect(); SelectedPos[1] += yMov; Select(); }
    public void DeSelect() { grid.SetTileDeSelected(SelectedPos[0],SelectedPos[1]); }
    public void Select() { grid.SetTileSelected(SelectedPos[0],SelectedPos[1]); }
}
