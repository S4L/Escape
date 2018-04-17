using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	private Rigidbody rb;
	public float speed;

	void Start(){
		rb = GetComponent<Rigidbody> ();
	}

	void FixedUpdate(){

		float x = Input.GetAxis ("Horizontal");
		float y = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (x, 0.0f, y); 
		rb.velocity = movement * speed; 
	}
}
