using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {

    public float speed = 1f;
    private Transform thisTransform;

	// Use this for initialization
	void Start () 
    {
        thisTransform = GetComponent<Transform>();	
	}
	
	// Update is called once per frame
	void Update () 
    {

        //thisTransform.Translate(Vector3.forward*Time.deltaTime * speed,Space.Self);
        //thisTransform.position += thisTransform.forward * Time.deltaTime;

        thisTransform.rotation = Quaternion.RotateTowards(thisTransform.rotation, Quaternion.Euler(0f, 100f, 0f), Time.deltaTime*speed);
	}
}
