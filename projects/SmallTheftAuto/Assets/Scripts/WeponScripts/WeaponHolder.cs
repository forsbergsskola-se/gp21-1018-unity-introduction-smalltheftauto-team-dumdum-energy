using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WeaponHolder : MonoBehaviour
{
    private Pistol _pistol;
    private AutomaticWeapon _auto;


    private void Start()
    {
       _pistol = GetComponent<Pistol>();
       _auto = GetComponent<AutomaticWeapon>();
       _pistol.enabled = false;
       _auto.enabled = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            _pistol.enabled = true;
            _auto.enabled = false;
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            _pistol.enabled = false;
            _auto.enabled = true;
        }
    }
}
