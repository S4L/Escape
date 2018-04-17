using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary{
	public float xMin, xMax, zMin,zMax;
}

public class PlayerBoundary : MonoBehaviour {

	public Boundary boundary;
	private Rigidbody rb;

	void Start(){
		rb = GetComponent<Rigidbody> ();
	}

	void FixedUpdate(){
		rb.position = new Vector3 (Mathf.Clamp (rb.position.x, boundary.xMin, boundary.xMax),0.0f, 
									Mathf.Clamp (rb.position.z, boundary.zMin, boundary.zMax));
	}
}
