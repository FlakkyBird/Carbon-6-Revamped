using UnityEngine;
using System.Collections;

public class Voxel : MonoBehaviour {


	void Update () {
		
	}



	public static GameObject LoadVoxel(string name){
	
		
		return (GameObject)Resources.Load ("Voxels/ " + name); 
	}



}


