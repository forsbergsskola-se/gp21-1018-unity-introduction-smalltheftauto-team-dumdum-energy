using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEditor.Search;
using UnityEngine;

public class Pistol : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject bulletprefab;
    public float Damage = 15;

    private int maxAmmo = 7;
    private int currentAmmo;
    private float reloadTime = 1f;
    private float bulletForce = 200f;
    private bool isReloading = false;

    private void Start()
    {
        spawnPoint = GetComponentInChildren<Transform>().Find("FirePoint");
        currentAmmo = maxAmmo;
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
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
    
    void Shoot()
    {
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
