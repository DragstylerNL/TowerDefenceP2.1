using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BaseTurret : MonoBehaviour {

    private string TRname;
    private float TRdamage, TRfirerate, TRbulletSpeed;
    private int TRcost = 10;
    private float TRfireReady;
    private float scanOfset = 0;

    public GameObject bullet;
	
    public void SetInfo(string name, float dmg,float firerate,float bulletSpeed,int cost)
    {
        TRname = name;
        TRdamage = dmg;
        TRfirerate = firerate;
        TRbulletSpeed = bulletSpeed;
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
        if(TRfireReady > 0) { TRfireReady -= Time.deltaTime; }
        CastRay();
    }

    private void CastRay()
    {
        RaycastHit hit;
        GameObject currentHit;
        if (Physics.Raycast(new Vector3(transform.position.x + 0.5f + scanOfset, transform.position.y, transform.position.z - 0.55f), Vector3.right, out hit))
        {
            currentHit = hit.collider.gameObject;
            if (currentHit.tag == "Turret")
            {
                scanOfset += 1.3f;
            }
            else if (currentHit.tag == "Enemy")
            {
                scanOfset = 0;
                Shoot();
            }
            else { scanOfset = 0; }
        }
    }

    private void Shoot()
    {
        if(TRfireReady <= 0)
        {
            TRfireReady = TRfirerate;
            GameObject readyBullet = bullet;
            readyBullet.transform.position = new Vector3(transform.position.x + 0.5f, transform.position.y, transform.position.z - 0.55f);
            readyBullet.GetComponent<Bullet>().SetStats(TRbulletSpeed, TRdamage);
            Instantiate(readyBullet);
        }
    }
}
