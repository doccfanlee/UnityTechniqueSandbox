using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetColorData : MonoBehaviour {

	public ColorData colorData;
	Renderer rend;

	void Awake()
	{
		rend = GetComponent<Renderer>();
	}
	// Use this for initialization
	void Start () 
	{
		Get_ColorData();
	}

	public void Get_ColorData()
	{
		rend.material.color = colorData.color;
	}

}
