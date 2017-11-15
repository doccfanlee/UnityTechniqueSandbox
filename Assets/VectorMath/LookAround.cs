using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAround : MonoBehaviour
{
    public Transform target;
    public float distance;
    public float speed;

    void Update()
    {
        float deltaY = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float deltaX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.Translate(deltaX, deltaY, 0f, Space.Self);
        transform.LookAt(target);

        Vector3 direction = transform.position - target.position;
        Vector3 newDistance = direction.normalized * distance;
        transform.position = target.position + newDistance;

    }
}
