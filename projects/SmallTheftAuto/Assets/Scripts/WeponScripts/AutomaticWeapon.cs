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
    private float reloadTime = 3f;
    private bool isReloading = false;
    public int maxAmmo = 32;
    private int currentAmmo;
    

    private void Start()
    {
        currentAmmo = maxAmmo;
        spawnPoint = GetComponentInChildren<Transform>().Find("FirePoint");
        InvokeRepeating(nameof(Shoot), 0,1/fireRate);
    }

    private void Update()
    {
        if (isReloading)
        {
            return;
        }

        if (currentAmmo <= 0)
        {
            StartCoroutine(Reload());
            return;
        }
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
        currentAmmo--;
        GameObject bullet = Instantiate(bulletprefab, spawnPoint.position, spawnPoint.rotation);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.AddForce(spawnPoint.forward*bulletForce, ForceMode.Impulse);
    }
    
    IEnumerator Reload()
    {
        isReloading = true;
        yield return new WaitForSeconds(reloadTime);
        currentAmmo = maxAmmo;
        isReloading = false;
    }
}
