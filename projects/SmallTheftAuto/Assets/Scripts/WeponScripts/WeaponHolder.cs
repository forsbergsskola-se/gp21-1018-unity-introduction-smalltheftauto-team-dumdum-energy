using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class WeaponHolder : MonoBehaviour
{
    private Pistol _pistol;
    private AutomaticWeapon _auto;
    private Knife _knife;
    public GameObject knife;
    public GameObject pistol;
    public GameObject Auto;
    


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
            pistol.gameObject.SetActive(true);
            Auto.gameObject.SetActive(false);
            knife.gameObject.SetActive(false);
                    
        }

        if (UseAutoWeapon())
        {
            _pistol.enabled = false;
            _auto.enabled = true;
            _knife.enabled = false;
            pistol.gameObject.SetActive(false);
            Auto.gameObject.SetActive(true);
            knife.gameObject.SetActive(false);
            
        }
        if (UseKnife())
        {
            _pistol.enabled = false;
            _auto.enabled = false;
            _knife.enabled = true;
            pistol.gameObject.SetActive(false);
            Auto.gameObject.SetActive(false);
            knife.gameObject.SetActive(true);


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
