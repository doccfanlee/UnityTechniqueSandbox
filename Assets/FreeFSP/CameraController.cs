using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public float XSensitivity = 0.2f;
    public float YSensitivity = 0.2f;
    public float MinimumX = -90F;
    public float MaximumX = 90F;
    public GameObject mainCamera;
    public float moveSpeed = 1f;

    private Quaternion CameraTargetRotation;
    private Quaternion CharacterTargetRotation;

	// Use this for initialization
	void Start () {
        CameraTargetRotation = mainCamera.transform.localRotation;
        CharacterTargetRotation = gameObject.transform.localRotation;
	}
	
	// Update is called once per frame
	void Update () {

        float yRot = Input.GetAxis("Mouse X") * XSensitivity;
        float xRot = Input.GetAxis("Mouse Y") * YSensitivity;

        CameraTargetRotation *= Quaternion.Euler(-xRot, 0f, 0f);
        CharacterTargetRotation *= Quaternion.Euler(0f, yRot, 0f);
        gameObject.transform.localRotation = ClampRotationAroundXAxis(CharacterTargetRotation);
        mainCamera.transform.localRotation = ClampRotationAroundXAxis(CameraTargetRotation);

        float fMovDelta = Input.GetAxis("Vertical");
        float rMovDelta = Input.GetAxis("Horizontal");
        mainCamera.transform.Translate(Vector3.forward * fMovDelta * Time.deltaTime * moveSpeed);
        mainCamera.transform.Translate(Vector3.right * rMovDelta * Time.deltaTime * moveSpeed);
    }

    Quaternion ClampRotationAroundXAxis(Quaternion q)
    {
        q.x /= q.w;
        q.y /= q.w;
        q.z /= q.w;
        q.w = 1.0f;

        float angleX = 2.0f * Mathf.Rad2Deg * Mathf.Atan(q.x);

        angleX = Mathf.Clamp(angleX, MinimumX, MaximumX);

        q.x = Mathf.Tan(0.5f * Mathf.Deg2Rad * angleX);

        return q;
    }
}
