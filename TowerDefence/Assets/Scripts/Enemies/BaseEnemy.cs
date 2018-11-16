using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEnemy : MonoBehaviour {

    private int Ehp, Espeed, Egain;

    public void SetInfo(int hp, int speed, int gain)
    {
        Ehp = hp;
        Espeed = speed;
        Egain = gain;
    }

    public void GetHit(int dmg)
    {
        Ehp -= dmg;
        // is dead?
        if (Ehp <= 0)
        {
            GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>().AddMoney(Egain);
            Destroy(this.gameObject);
        }
    }
	
	void Update () {
        // move 
        transform.position -= Vector3.right * Espeed * Time.deltaTime;
	}
}
