using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSaveLoadData : MonoBehaviour {

	public bool isFiring;

	public void SaveCamera()
	{
		SaveLoadData.SaveData(transform,isFiring);	
	}

	public void LoadCamera()
	{
		CameraData cameraData = SaveLoadData.LoadData();
		if (cameraData != null) {
			transform.position = new Vector3(cameraData.position[0],cameraData.position[1], cameraData.position[2]);
			transform.rotation = new Quaternion(cameraData.rotation[0],cameraData.rotation[1],cameraData.rotation[2],cameraData.rotation[3]);
			isFiring = cameraData.isFiring;
		}
	}
}
