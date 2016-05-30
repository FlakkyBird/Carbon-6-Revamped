using UnityEngine;
using System.Collections;

public class PlayerGarage : MonoBehaviour {


	/**
	 * <summary>
	 * Raycast a GameObject
	 * and instantiate the selected voxel
	 * at a rounded position based on the normals
	 * of the hitted raycast
	 * </summary>
	 */

	//The build distance
	public float buildDist;

	//The data that the raycast hit.
	RaycastHit hit; 

	// Update is called once per frame
	void Update () {


		if (Physics.Raycast (Camera.main.ScreenPointToRay (new Vector3 (Screen.width / 2, Screen.height / 2)), out hit, buildDist, 0)) {
			Debug.Log ("Oi");
			}
	
			}

		


}

