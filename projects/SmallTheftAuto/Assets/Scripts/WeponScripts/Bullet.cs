using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.gameObject.CompareTag("Car"))
        { 
            other.gameObject.GetComponent<CarHealth>()._CarHealth -= FindObjectOfType<Weapon>().Damage;
            Debug.Log(other.gameObject.GetComponent<CarHealth>()._CarHealth);
        }
        Destroy(gameObject);
    }
}
