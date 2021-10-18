using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;
    public float delay;
    public Vector3 offset;
    // Update is called once per frame
    void Update()
    {
        Vector3 dumDum = Vector3.Lerp(transform.position, player.position, delay);
        transform.position = dumDum + offset;
    }
}
