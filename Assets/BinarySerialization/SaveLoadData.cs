using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public static class SaveLoadData 
{
	public static void SaveData(Transform transform, bool isFiring)
	{
		BinaryFormatter bf = new BinaryFormatter();
		FileStream stream = new FileStream(Application.persistentDataPath + "/camera.data", FileMode.Create);

		CameraData cameraData = new CameraData(transform, isFiring);

		bf.Serialize(stream,cameraData);
		stream.Close();
	}

	public static CameraData LoadData()
	{
		if (File.Exists(Application.persistentDataPath + "/camera.data")) 
		{
			BinaryFormatter bf = new BinaryFormatter();
			FileStream stream = new FileStream(Application.persistentDataPath + "/camera.data", FileMode.Open);

			CameraData cameraData = bf.Deserialize(stream) as CameraData;

			stream.Close();
			return cameraData;
		}
		else
		{
			return null;
		}

	}
}
