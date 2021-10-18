using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform targetObject;

    public Vector3 cameraOffset;

    public float speed;

    public float delay;
    // Start is called before the first frame update
    void Start()
    {
        cameraOffset = transform.position - targetObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 dumDum = Vector3.Lerp(transform.position, player.position, delay);
        Vector3 newPosition = Vector3.Lerp(targetObject.transform.position, targetObject.transform.position, delay) ;
        transform.position = newPosition;
    }
}
