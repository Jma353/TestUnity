using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	// Refers to the player 
	public GameObject player; 

	// Initialized @ start 
	private Vector3 offset; 

	// Use this for initialization
	void Start () {
		// Grab the initial offset 
		offset = this.transform.position - player.transform.position; 
	}
	
	// LateUpdate to update this after everything is done 
	void LateUpdate () {
		// Reset the camera 
		this.transform.position = player.transform.position + offset; 
	}
}
