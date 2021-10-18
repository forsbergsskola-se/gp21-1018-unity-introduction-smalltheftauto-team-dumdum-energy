using System.Collections;
using System.Collections.Generic;
using UnityEngine;

        
public class CameraControllerEK : MonoBehaviour
{
    public Transform target;

    public float speed = 0.125f;
    public Vector3 offset;

    // Start is called before the first frame update
    private void Update()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, speed);
        transform.position = smoothedPosition;

        transform.LookAt(target);
    }
}