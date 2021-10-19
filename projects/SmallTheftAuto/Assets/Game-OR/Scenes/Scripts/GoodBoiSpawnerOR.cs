using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodBoiSpawnerOR : MonoBehaviour
{
    public GameObject DogORPrefab;
    private GameObject DogInstance;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(DogORPrefab);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
