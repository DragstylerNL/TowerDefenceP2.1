using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseTurret : MonoBehaviour {

    private string TRname;
    private float TRdamage, TRfirerate;
	
    public void SetInfo(string name, float dmg,float firerate)
    {
        TRname = name;
        TRdamage = dmg;
        TRfirerate = firerate;
    }
	void Start () {
        GameController gmc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        gmc.GetSelectedPos();
	}
}
