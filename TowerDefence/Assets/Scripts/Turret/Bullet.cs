using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    [SerializeField]
    private float BLspeed, BLdamage;
	
    public void SetStats(float speed, float damage)
    {
        BLspeed = speed;
        BLdamage = damage;
    }

	void Update () {
        transform.position += Vector3.right * BLspeed * Time.deltaTime;
        CastRay();
    }

    private void CastRay()
    {
        RaycastHit hit;
        GameObject currentHit;
        if (Physics.Raycast(new Vector3(transform.position.x + 0.1f, transform.position.y, transform.position.z), Vector3.right, out hit))
        {
            currentHit = hit.collider.gameObject;
            if (currentHit.tag == "Enemy" && currentHit.transform.position.x - transform.position.x < 1)
            {
                print("HIT");
                BaseEnemy norm = currentHit.GetComponentInParent<BaseEnemy>();
                norm.GetHit((int)BLdamage);
                Destroy(this.gameObject);
            }
        }
    }
}
