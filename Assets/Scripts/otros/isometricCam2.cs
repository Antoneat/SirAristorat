using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isometricCam2 : MonoBehaviour
{

    public GameObject lookAt;

    private bool smooth = true;
    private float smoothSpeed = 0.125f;
    private Vector3 offset = new Vector3(10, 30, 10);

    private void Start()
    {
        lookAt = GameObject.FindGameObjectWithTag("Player");
    }

    private void LateUpdate()
    {
        Vector3 desiredPosition = lookAt.transform.position + offset;

        if (smooth)
        {
            transform.position = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        }

        else
        {
            transform.position = desiredPosition;
        }
    }
}
