using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  [SerializeField] CharacterController cController;

	private void Start() {
		// Accessing Character Controller attached to the player
		cController = GetComponent<CharacterController> ();
	}
	
	private void Update() {
		// Pc Controls
		if (Input.GetKeyDown(KeyCode.RightArrow)) Movement("Right");
		if (Input.GetKeyDown(KeyCode.LeftArrow)) Movement("Left");
		if (Input.GetKeyDown(KeyCode.UpArrow)) Movement("Forward");
		if (Input.GetKeyDown(KeyCode.DownArrow)) Movement("Back");
	}

	// Player Movements
	public void Movement(string dir) {
		switch (dir) {
			case "Right":
				cController.Move(Vector3.right);
				break;
			case "Left":
				cController.Move(Vector3.left);
				break;
			case "Forward":
				cController.Move(Vector3.forward);
				break;
			case "Back":
				cController.Move(Vector3.back);
				break;
		}
	}
}