using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour {

    public string entity = "Empty";
    public int x = 0, y = 0;
	public bool isSelected = false;
    
    private GameObject marked;

    void Awake()
    {
        marked = GameObject.FindGameObjectWithTag("Marked");
    }

    public void Select()
    {
        isSelected = true;
        marked.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 2);
    }

    public void DeSelect()
    {
        isSelected = false;
    }

}