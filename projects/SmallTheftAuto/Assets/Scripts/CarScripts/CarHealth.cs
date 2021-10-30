using System;
using System.Collections;
using System.Collections.Generic;
using CarScripts;
using UnityEngine;

public class CarHealth : MonoBehaviour
{
    private float _CarMaxHealth = 300f;
    private float _CarHealth;
    private float _crashDamage;
    // Start is called before the first frame update
    void Start()
    {
        _CarHealth = _CarMaxHealth;
        _crashDamage = _CarMaxHealth / 5;
        
    }

    private void LateUpdate()
    {
        Exploded();
    }

    private void OnCollisionEnter(Collision other)
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        float velocity = rb.velocity.magnitude;
        if (velocity > 2)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                Debug.Log("You don't scare me.");
            }
            else if (other.gameObject.CompareTag("Environment"))
            {
                _CarHealth -= _crashDamage;
                Debug.Log(_CarHealth);
            }

            if (_CarHealth< _CarMaxHealth*0.25)
            {
                Debug.Log("Im on fire.");
                //add GFX for the fire and activate here.
            }
        }
    }

    void Exploded()
    {
        if (_CarHealth <= 0 )
        {
            Debug.Log("I exploded!");
            GetComponent<CarMovement>().enabled = false;
            GetComponent<Vehicle>().enabled = false;
            
        }
    }

    public bool KillCar()
    {
        if (_CarHealth <= 0)
        {
            return true;
        }
        return false;
    }
}
