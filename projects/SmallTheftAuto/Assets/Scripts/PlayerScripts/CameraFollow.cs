using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.Camera;

public class CameraFollow : MonoBehaviour
{
    public Transform target;

    public Vector3 offset;
    public float speed;
    private Camera _camera;

    // Start is called before the first frame update
    void Start()
    {
        _camera = GetComponent<Camera>();
        //cameraOffset = transform.position - targetObject.transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (target.gameObject.activeInHierarchy)
        {
            _camera.orthographicSize = 3f;
            Vector3 desiredPosition = target.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, speed);
            transform.position = smoothedPosition;   
        }
        else if (!target.gameObject.activeInHierarchy)
        {
            _camera.orthographicSize = 8f;
            var car = FindObjectOfType<CarMovement>();
            Vector3 carDesired = car.transform.position + offset;
            Vector3 carSmooth = Vector3.Lerp(transform.position, carDesired, speed);
            transform.position = carSmooth;
        }
    }
}
