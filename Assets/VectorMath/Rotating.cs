using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotating : MonoBehaviour {
    public Transform toTransform;
    public float speed = 1f;

    private Transform thisTransform;

    private void Start()
    {
        thisTransform = GetComponent<Transform>();
		//thisTransform.Rotate(new Vector3(89f, 0f, 0f));

	}

    // Update is called once per frame
    void Update()
    {
        //thisTransform.rotation *= Quaternion.AngleAxis(speed * Time.deltaTime, Vector3.up);
        // thisTransform.LookAt(toTransform,Vector3.up);
        Quaternion toRotation = Quaternion.LookRotation(toTransform.position - thisTransform.position, Vector3.up);
       thisTransform.rotation = Quaternion.RotateTowards(thisTransform.rotation,toRotation, speed*Time.deltaTime);
    }
}
