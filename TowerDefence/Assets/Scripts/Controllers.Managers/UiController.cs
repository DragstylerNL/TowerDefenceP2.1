using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiController : MonoBehaviour {

    public Text TXTmoney;

	void Update () {
        TXTmoney.text = "Money: " + GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>().GetMoney();
	}
}
