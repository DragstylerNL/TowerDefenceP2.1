using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    //game Variables
    private int money = 0, wave = 1;
    

    //turret list
    [SerializeField]
    private GameObject[] prefabs = new GameObject[2];

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

    public void RequestTurret(int turretNumber)
    {
        if (grid.GetTileEnt(SelectedPos[0], SelectedPos[1]) == "Empty")
        {
            int cost = 0;
            switch (turretNumber) {
                case 0: cost = prefabs[turretNumber].GetComponent<NormyTurret>().GetCost();
                    if (money >= cost){ PlaceTurret(turretNumber, prefabs[turretNumber].GetComponent<NormyTurret>().GetName()); }
                    break;
            }
            
        }
    }

    private void PlaceTurret(int turretRequested, string turretName)
    {

        GameObject currentTurret = Instantiate(prefabs[turretRequested]);
        currentTurret.transform.position = new Vector3(grid.GetWorldPos(SelectedPos[0], SelectedPos[1])[0], grid.GetWorldPos(SelectedPos[0], SelectedPos[1])[1], 0);
        grid.SetTileEnt(SelectedPos[0], SelectedPos[1], turretName);
    }
}
