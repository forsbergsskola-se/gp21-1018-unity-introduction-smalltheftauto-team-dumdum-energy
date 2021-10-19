using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompanionSpawnerIL : MonoBehaviour
{
    private GameObject _dogInstance;
    public GameObject dogPrefab;
    // Start is called before the first frame update
    void Start()
    {
       _dogInstance = Instantiate(dogPrefab);
    }

    private void OnDestroy()
    {
        Destroy(_dogInstance);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
