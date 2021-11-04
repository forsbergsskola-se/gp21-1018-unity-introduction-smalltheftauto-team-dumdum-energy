using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject bulletprefab;
    public float Damage = 10;

    private float bulletForce = 200f;

    private void Start()
    {
        spawnPoint = GetComponentInChildren<Transform>().Find("FirePoint");
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
       GameObject bullet = Instantiate(bulletprefab, spawnPoint.position, spawnPoint.rotation);
       Rigidbody rb = bullet.GetComponent<Rigidbody>();
       rb.AddForce(spawnPoint.forward*bulletForce, ForceMode.Impulse);
    }
}
