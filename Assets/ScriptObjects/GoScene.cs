using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoScene : MonoBehaviour {

	public string scene;

	void OnMouseDown()
	{
		SceneManager.LoadSceneAsync(scene,LoadSceneMode.Single);	
	}
}
