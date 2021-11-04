using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WeaponHolder : MonoBehaviour
{
    private Pistol _pistol;
    private AutomaticWeapon _auto;
    private Knife _knife;
    public GameObject knife;


    private void Start()
    {
       _pistol = GetComponent<Pistol>();
       _auto = GetComponent<AutomaticWeapon>();
       _knife = GetComponent<Knife>();
       _knife.enabled = false;
       _pistol.enabled = false;
       _auto.enabled = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            _pistol.enabled = true;
            _auto.enabled = false;
            _knife.enabled = false;
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            _pistol.enabled = false;
            _knife.enabled = false;
            _auto.enabled = true;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            _pistol.enabled = false;
            _knife.enabled = true;
            FindObjectOfType<Knife>().gameObject.SetActive(true);
            
            _auto.enabled = false;
        }
    }
}
