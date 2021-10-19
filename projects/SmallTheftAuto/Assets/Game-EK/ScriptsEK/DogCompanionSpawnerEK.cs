using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogCompanionSpawnerEK : MonoBehaviour
{
    public GameObject DogPrefab;

    private GameObject DogInstance;
    // Start is called before the first frame update
    void OnEnable()
    {
        DogInstance = Instantiate(DogPrefab);
    }

    private void OnDisable()
    {
        Destroy(DogInstance);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
