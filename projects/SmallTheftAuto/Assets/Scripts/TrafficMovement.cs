using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TrafficMovement : MonoBehaviour
{
    private Transform start;
    private Transform end;
    private float speed = 0.5f;
    private float startTime;
    private float length;
    private bool turn = false;

    private void Start()
    {
        start = FindObjectOfType<TraficSpawner>().start;
        end = FindObjectOfType<TraficSpawner>().end;
        startTime = Time.time;
        length = Vector3.Distance(start.position, end.position);
    }

    // Update is called once per frame
    void Update()
    {
        float distCovered = (Time.time - startTime) * speed;
        float fractDistance = distCovered / length;
        transform.position = Vector3.Lerp(start.position, end.position, fractDistance);
        if (end.transform.position == transform.position)
        {
            Destroy(gameObject);
        }
    }
}
