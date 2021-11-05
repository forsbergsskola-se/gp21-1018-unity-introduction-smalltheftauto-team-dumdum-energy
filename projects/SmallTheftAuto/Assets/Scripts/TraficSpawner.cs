using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TraficSpawner : MonoBehaviour
{
    public Transform start;
    public Transform end;
    private float speed = 0.5f;
    private float startTime;
    private float length;
    private bool turn = false;
    public GameObject car;

    private void Start()
    {
        start = FindObjectOfType<TraficSpawner>().start;
        end = FindObjectOfType<TraficSpawner>().end;
        InvokeRepeating("Spawn",5,1);
    }

    // Update is called once per frame
    void Spawn()
    {
        Instantiate(car);
    }
}
