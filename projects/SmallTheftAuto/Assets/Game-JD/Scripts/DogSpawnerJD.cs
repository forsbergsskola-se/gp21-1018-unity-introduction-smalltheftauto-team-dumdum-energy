using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogSpawnerJD : MonoBehaviour
{
    public GameObject dogPrefab;

    private GameObject _dogInstance;
    void OnEnable()
    {
        _dogInstance = Instantiate(dogPrefab);
    }
    private void OnDisable()
    {
        Destroy(_dogInstance);
    }
}
