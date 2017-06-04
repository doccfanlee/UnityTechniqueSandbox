using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class CameraData  
{
	public float[] position;
	public float[] rotation;
	public bool isFiring;

	public CameraData(Transform transform, bool isFiring)
	{
		position = new float[3];
		rotation = new float[4];
		isFiring = new bool();

		position[0] = transform.position.x;
		position[1] = transform.position.y;
		position[2] = transform.position.z;

		rotation[0] = transform.rotation.x;
		rotation[1] = transform.rotation.y;
		rotation[2] = transform.rotation.z;
		rotation[3] = transform.rotation.w;

		this.isFiring = isFiring;
	}
}
