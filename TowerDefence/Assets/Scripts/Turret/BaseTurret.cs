using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BaseTurret : MonoBehaviour {

    private string TRname;
    private float TRdamage, TRfirerate;
    private int TRcost;
	
    public void SetInfo(string name, float dmg,float firerate,int cost)
    {
        TRname = name;
        TRdamage = dmg;
        TRfirerate = firerate;
        TRcost = cost;
    }

    public string GetName() { return TRname; }
    public int GetCost() { return TRcost; }


    void Start () {
        GameController gmc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        gmc.GetSelectedPos();
	}

    void Update()
    {
        if (Physics.Raycast(new Vector3(transform.position.x, transform.position.y, transform.position.z), new Vector3(1, 0, 0))){
            

        }
    }
}
