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
            other.gameObject.GetComponent<IEnemy>().TakeDamage(10);
        }

        if (other.collider.gameObject.CompareTag("Enemy"))
        {
            other.gameObject.GetComponent<IEnemy>().TakeDamage(3);
        }
        Destroy(gameObject);
    }
}
