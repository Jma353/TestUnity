using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float thrust; 
	private Rigidbody rb; 

	void Start () {
		// Pull reference to the object's rigid body 
		rb = GetComponent<Rigidbody>(); 
	}

	void FixedUpdate () {

		// Pull inputs 
		float moveHorizontal = Input.GetAxis("Horizontal"); 
		float moveVertical = Input.GetAxis("Vertical"); 

		// Compute the direction of movement 
		Vector3 direction = new Vector3(moveHorizontal*thrust, 0.0f, moveVertical*thrust); 

		// Apply this directional force to the rigid body
		rb.AddForce(direction); 

	}



}
