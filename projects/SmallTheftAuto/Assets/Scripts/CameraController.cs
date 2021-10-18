using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;
    public Transform endMarker;
    public float delay;
    public Vector3 offset;
    private float starttime;
    private float journeyLength;
    private void Start()
    {
        starttime = Time.time;
        journeyLength = Vector3.Distance(player.position, endMarker.position);
    }

    // Update is called once per frame
    void Update()
    {
        float distCovered = (Time.time - starttime) * delay;
        float fractionofJourney = distCovered / journeyLength;
        //Vector3 dumDum = Vector3.Lerp(transform.position, player.position, delay);
        //transform.position = dumDum + offset;
        transform.position = Vector3.Lerp(player.position, endMarker.position, fractionofJourney);
    }

    private void FixedUpdate()
    {
        
    }
}
