using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;

    private Vector3 _camOffset;


    [Range(0.01f, 1.0f)]
    public float smoothFactor = 0.5f;

    public bool lookAtPlayer = false;

    public bool rotateAround = true;
    public float rotationSpeed = 5f;


    void Start()
    {
        _camOffset = transform.position - target.position;
    }

    void FixedUpdate()
    {
        if (rotateAround)
        {
            Quaternion camTurnAngle = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * rotationSpeed, Vector3.up);

            _camOffset = camTurnAngle * _camOffset;
        }

        Vector3 newPos = target.position + _camOffset;

        transform.position = Vector3.Slerp(transform.position, newPos, smoothFactor);

        if (lookAtPlayer || rotateAround)
        {
           
            transform.LookAt(target);
            
        }
    }

    
}
