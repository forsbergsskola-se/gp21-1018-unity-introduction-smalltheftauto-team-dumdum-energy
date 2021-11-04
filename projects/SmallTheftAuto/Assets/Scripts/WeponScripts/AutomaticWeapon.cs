using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;

public class AutomaticWeapon : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject bulletprefab;
    public float Damage = 10;
    private float fireRate = 10f;
    private bool shooting = false;
    private float bulletForce = 200f;
    public int slot = 2;

    private void Start()
    {
        spawnPoint = GetComponentInChildren<Transform>().Find("FirePoint");
        InvokeRepeating(nameof(Shoot), 0,1/fireRate);
    }

    private void Update()
    {
        shooting = false;
        if (Input.GetButton("Fire1"))
        {
            shooting = true;
        }
    }
    
    void Shoot()
    {
        if (!shooting)
        {
            return;
        }
        GameObject bullet = Instantiate(bulletprefab, spawnPoint.position, spawnPoint.rotation);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.AddForce(spawnPoint.forward*bulletForce, ForceMode.Impulse);
    }
}
