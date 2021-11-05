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
        if (UsePistol())
        {
            _pistol.enabled = true;
            _auto.enabled = false;
            _knife.enabled = false;
        }

        if (UseAutoWeapon())
        {
            _pistol.enabled = false;
            _knife.enabled = false;
            _auto.enabled = true;
        }
        if (UseKnife())
        {
            _pistol.enabled = false;
            _knife.enabled = true;


            _auto.enabled = false;
            FindObjectOfType<Knife>().gameObject.SetActive(true);


        }
    }

    private static bool UseKnife()
    {
        return Input.GetKeyDown(KeyCode.Alpha3);
    }

    private static bool UseAutoWeapon()
    {
        return Input.GetKeyDown(KeyCode.Alpha2);
    }

    private static bool UsePistol()
    {
        return Input.GetKeyDown(KeyCode.Alpha1);
    }
}
