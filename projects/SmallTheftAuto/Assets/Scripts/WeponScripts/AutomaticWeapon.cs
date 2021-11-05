using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;
using UnityEngine.UI;

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
    private int maxAmmo = 32;
    public int currentAmmo;

    public GameObject AutoRifleAmmoUi;


    private void Start()
    {
        currentAmmo = maxAmmo;
        spawnPoint = GetComponentInChildren<Transform>().Find("FirePoint");
        InvokeRepeating(nameof(Shoot), 0,1/fireRate);
        AutoRifleAmmoUi.GetComponent<Text>().text = $"Rifle: {currentAmmo} / {maxAmmo}";
    }

    private void OnEnable()
    {
        AutoRifleAmmoUi.GetComponent<Text>().text = $"Rifle: {currentAmmo} / {maxAmmo}";
    }

    private void Update()
    {
        if (isReloading)
        {
            return;
        }
        shooting = false;
        if (currentAmmo <= 0)
        {
            Debug.Log("Reloading Autmatic Weapon...");
            AutoRifleAmmoUi.GetComponent<Text>().text = $"Rifle is Reloading...";
            StartCoroutine(Reload());
            return;
        }
        else
        {
            if (Input.GetButton("Fire1"))
            {
                shooting = true;
            }
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
        AutoRifleAmmoUi.GetComponent<Text>().text = $"Rifle: {currentAmmo} / {maxAmmo}";
    }
    
    IEnumerator Reload()
    {
        isReloading = true;
        yield return new WaitForSeconds(reloadTime);
        currentAmmo = maxAmmo;
        isReloading = false;
        AutoRifleAmmoUi.GetComponent<Text>().text = $"Rifle: {currentAmmo} / {maxAmmo}";
    }
}
