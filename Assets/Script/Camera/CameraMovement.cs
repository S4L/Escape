using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

	//public CamBoundary camBound;
	public Transform playerTransform;
	
	// Update is called once per frame
	void Update () {
			transform.position = new Vector3 (Mathf.Lerp (transform.position.x, playerTransform.position.x, 0.2f), 3.0f, 
				Mathf.Lerp (transform.position.z, playerTransform.position.z, 0.2f));
	}
}
