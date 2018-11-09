using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour {

    public string entity = "Empty";
    public int x = 0, y = 0;
	public bool isSelected = false;

    [SerializeField]
    private GameObject marked;

    public void Select()
    {
        isSelected = true;
        marked.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 2);
        Instantiate(marked);
    }

    public void DeSelect()
    {
        isSelected = false;
        Destroy(marked);
    }

}