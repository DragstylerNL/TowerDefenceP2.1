using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public Grid grid;
    
    [SerializeField]
    private int[] SelectedPos = new int[2];
    
	void Start () {

    }
	
	void Update () {
		
	}

    public int[] GetSelectedPos()
    {
        return SelectedPos;
    }

    public void SetSelectedX(int xMov) { DeSelect(); SelectedPos[0] += xMov; }
    public void SetSelectedY(int yMov) { DeSelect(); SelectedPos[1] += yMov; }
    public void DeSelect() { }
}
