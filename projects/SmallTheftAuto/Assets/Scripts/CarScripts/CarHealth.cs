using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarHealth : MonoBehaviour
{
    public GameObject car;
    private float _CarMaxHealth = 300f;
    private float _CarHealth;
    // Start is called before the first frame update
    void Start()
    {
        _CarHealth = _CarMaxHealth;
        float crashDamage = _CarMaxHealth / 5;
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
        
        
        
        
    }

    private void OnCollisionEnter(Collision other)
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        float velocity = rb.velocity.magnitude;
        if (velocity > 300)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                
            }
            
        }
    }
}
