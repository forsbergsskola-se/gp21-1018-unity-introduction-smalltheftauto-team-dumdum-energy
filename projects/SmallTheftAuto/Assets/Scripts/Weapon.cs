using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    private string name;
    private int damage = 10;
    private float fireRate = 0.25f;
    private float range = 50f;
    private Player player;

    private Ray ray;
    private RaycastHit hit;

    private void Start()
    {
        name = "Hello";
        player = FindObjectOfType<Player>();

        ray.origin = player.transform.position;
        ray.direction = player.transform.forward;
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (Physics.Raycast(ray, out hit))
            {
                Debug.DrawLine(ray.origin, hit.point, Color.red, 1.0f);
            }
            
        }
    }

    void AttackPlayer()
    {
        FindObjectOfType<Player>().currentHealth -= damage;
    }

    void AttackCar()
    {
        FindObjectOfType<CarHealth>()._CarHealth -= damage;
    }
}
