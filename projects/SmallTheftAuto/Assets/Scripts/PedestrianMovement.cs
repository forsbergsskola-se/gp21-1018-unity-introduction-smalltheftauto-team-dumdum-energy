using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PedestrianMovement : MonoBehaviour
{
    public Transform start;
    public Transform end;
    private float speed = 0.5f;
    private float startTime;
    private float length;
    private bool turn = false;

    private void Start()
    {
        startTime = Time.time;
        length = Vector3.Distance(start.position, end.position);
    }

    // Update is called once per frame
    void Update()
    {
        float distCovered = (Time.time - startTime) * speed;
        float fractDistance = distCovered / length;
        float time = Mathf.PingPong((Time.time * speed), 1);
        transform.position = Vector3.Lerp(start.position, end.position, time);
    }
}
