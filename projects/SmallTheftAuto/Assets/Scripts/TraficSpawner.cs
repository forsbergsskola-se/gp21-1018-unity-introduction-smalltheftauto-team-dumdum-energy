using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TraficSpawner : MonoBehaviour
{
    public Transform start;
    public Transform end;
    public GameObject car;

    // TODO: Nice! :)
    private void Start()
    {
        start = FindObjectOfType<TraficSpawner>().start;
        end = FindObjectOfType<TraficSpawner>().end;
        InvokeRepeating("Spawn",5,5f);
    }

    // Update is called once per frame
    void Spawn()
    {
        Instantiate(car);
    }
}
