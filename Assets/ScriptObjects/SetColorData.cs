using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetColorData : MonoBehaviour {

	public ColorData colorData;
	Material mat;

	void Awake()
	{
		mat = GetComponent<Renderer>().material;
	}

	void Start()
	{
		Set_ColorData(colorData);
	}

	public void Set_ColorData(ColorData colorData)
	{
		colorData.color = mat.color;
	}
}
