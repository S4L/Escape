using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CamBoundary{
	public float xMin,xMax,zMin,zMax;
}

public class CameraBoundary : MonoBehaviour {
	public CamBoundary camBound;
	
	// Update is called once per frame
	void Update () {

		transform.position = new Vector3 (Mathf.Clamp (transform.position.x, camBound.xMin, camBound.xMax), 0.0f,
			Mathf.Clamp (transform.position.z, camBound.zMin, camBound.zMax));
	}
}
