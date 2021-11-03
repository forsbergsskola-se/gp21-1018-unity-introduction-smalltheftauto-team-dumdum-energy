using System;
using System.Collections;
using System.Collections.Generic;
using CarScripts;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class CarHealth : MonoBehaviour
{
    private float _CarMaxHealth = 300f;
    public float _CarHealth;
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
    public UnityEvent OnCarBoom;
    void Exploded()
    {
        if (_CarHealth <= 0 )
        {
            Debug.Log("I exploded!");
            FindObjectOfType<Canvas>().GetComponentInChildren<TextMeshPro>().enabled = true;
            GetComponent<CarMovement>().enabled = false;
            GetComponent<Vehicle>().enabled = false;
            OnCarBoom.Invoke();
            

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
