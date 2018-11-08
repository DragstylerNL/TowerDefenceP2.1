using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour {

    private bool up, down, left, right;

    [SerializeField]
    private GameController gameController;
    
	void Update () {
        up = Input.GetButtonDown("Up");
        down = Input.GetButtonDown("Down");
        left = Input.GetButtonDown("Left");
        right = Input.GetButtonDown("Right");

        if (up && gameController.GetSelectedPos()[1] !=0) { gameController.SetSelectedY(-1); }
        if (down && gameController.GetSelectedPos()[1] !=4) { gameController.SetSelectedY(1); }
        if (left && gameController.GetSelectedPos()[0] !=0) { gameController.SetSelectedX(-1); }
        if (right && gameController.GetSelectedPos()[0] !=12) { gameController.SetSelectedX(1); }
    }
}
