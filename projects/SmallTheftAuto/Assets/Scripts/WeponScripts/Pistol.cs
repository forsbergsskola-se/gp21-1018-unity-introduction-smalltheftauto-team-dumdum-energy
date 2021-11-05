using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEditor.Search;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Pistol : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject bulletprefab;
    public float Damage = 15;

    private int maxAmmo = 7;
    public int currentAmmo;
    private float reloadTime = 1f;
    private float bulletForce = 200f;
    private bool isReloading = false;

    public GameObject PistolAmmoUi;


    private void Start()
    {
        spawnPoint = GetComponentInChildren<Transform>().Find("FirePoint");
        currentAmmo = maxAmmo;
        PistolAmmoUi.GetComponent<Text>().text = $"Pistol: {currentAmmo} / {maxAmmo}";
    }
    private void OnEnable()
    {
        PistolAmmoUi.GetComponent<Text>().text = $"Pistol: {currentAmmo} / {maxAmmo}";
    }
    private void Update()
    {
        
        if (isReloading)
        {
            return;
        }
        if (currentAmmo <= 0)
        {
            Debug.Log("Reloading Pistol...");
            PistolAmmoUi.GetComponent<Text>().text = $"Pistol is Reloading...";
            StartCoroutine(Reload());
            return;
        }
        else
        {
            if (Input.GetButtonDown("Fire1"))
            {
                Shoot();
            }
        }
    }
    
    void Shoot()
    {
        currentAmmo--;
        GameObject bullet = Instantiate(bulletprefab, spawnPoint.position, spawnPoint.rotation);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.AddForce(spawnPoint.forward*bulletForce, ForceMode.Impulse);
        PistolAmmoUi.GetComponent<Text>().text = $"Pistol: {currentAmmo} / {maxAmmo}";
    }

    IEnumerator Reload()
    {
        isReloading = true;
        yield return new WaitForSeconds(reloadTime);
        currentAmmo = maxAmmo;
        isReloading = false;
        PistolAmmoUi.GetComponent<Text>().text = $"Pistol: {currentAmmo} / {maxAmmo}";
    }
}
