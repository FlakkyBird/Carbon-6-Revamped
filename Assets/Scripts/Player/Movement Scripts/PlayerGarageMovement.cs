using UnityEngine;
using System.Collections;

public class PlayerGarageMovement : MonoBehaviour {

	//The speed at which we move
	public float MovementSpeed;

	//The player GameObject
	public GameObject Player;

	// Update is called once per frame
	void Update () {

		//Get input and move the player corrispondantly
		if (Input.GetKey (KeyCode.W)) {
			Player.transform.Translate(MoveInDirection ("Forward", MovementSpeed));
		}
		if (Input.GetKey (KeyCode.S)) {
			Player.transform.Translate(MoveInDirection ("Backward", MovementSpeed));
		}
		if (Input.GetKey (KeyCode.A)) {
			Player.transform.Translate(MoveInDirection ("Left", MovementSpeed));;
		}
		if (Input.GetKey (KeyCode.D)) {
			Player.transform.Translate(MoveInDirection ("Right", MovementSpeed));
		}
		if (Input.GetKey (KeyCode.Space)) {
			Player.transform.Translate(MoveInDirection ("Up", MovementSpeed / 2));
		}
		if (Input.GetKey (KeyCode.LeftShift)) {
			Player.transform.Translate(MoveInDirection ("Down", MovementSpeed / 2));
		}

	}
	static Vector3 MoveInDirection(string Direction,float Speed){
		/*
		 * <summary>
		 * Move the GameObject in the corresponding direction that
		 * is returned by the string name 'Direction'
		 * </summary>
		 */
		if (Direction == "Forward") {return Vector3.forward * Speed * Time.deltaTime;}
		if (Direction == "Backward") {return Vector3.back * Speed * Time.deltaTime;}
		if (Direction == "Left") {return Vector3.left * Speed * Time.deltaTime;}
		if (Direction == "Right") {return Vector3.right * Speed * Time.deltaTime;}
		if (Direction == "Up") {return Vector3.up * Speed * Time.deltaTime;}
		if (Direction == "Down") {return Vector3.down * Speed * Time.deltaTime;}

		//Return null if no code paths are found, Or if the user hasnt typed in a correct Direction 
		return new Vector3(0,0,0);
		}
}
