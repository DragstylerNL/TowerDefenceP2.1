using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour {

    private float waveDuration = 2, waveTimer = 0;

    private GameController gmController;

    public GameObject enemy;

	// Use this for initialization
	void Start () {
        gmController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
	}
	
	// Update is called once per frame
	void Update () {
        waveTimer -= Time.deltaTime;
		if(waveTimer <= 0)
        {
            waveTimer = waveDuration;
            Spawn();
        }
	}
    void Spawn()
    {
        int rdnNumber = Mathf.FloorToInt(Random.Range(0, 4.99f));
        GameObject Cenemy = enemy;
        switch (rdnNumber)
        {
            case 0:
                Cenemy.transform.position = new Vector3(8.5f, 2.6f, -0.55f);
                break;
            case 1:
                Cenemy.transform.position = new Vector3(8.5f, 1.3f, -0.55f);
                break;
            case 2:
                Cenemy.transform.position = new Vector3(8.5f, 0, -0.55f);
                break;
            case 3:
                Cenemy.transform.position = new Vector3(8.5f, -1.3f, -0.55f);
                break;
            case 4:
                Cenemy.transform.position = new Vector3(8.5f, -2.6f, -0.55f);
                break;
        }
        Instantiate(Cenemy);
        if (waveDuration >= 0.5f)
        {
            waveDuration -= 0.01f;
        }
    }
}
