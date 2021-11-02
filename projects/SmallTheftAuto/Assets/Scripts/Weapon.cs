using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    private string name;
    private int damage;
    private Player player;

    private void Start()
    {
        name = "Hello";
        damage = 10;
        player = FindObjectOfType<Player>();
    }

    void AttackPlayer()
    {
        FindObjectOfType<Player>().currentHealth -= damage;
    }

    void AttackCar()
    {
        FindObjectOfType<CarHealth>()._CarHealth -= damage;
    }

    void Hit()
    {
        //logic for if the attacks hit or not
        
        transform.rotation = player.transform.rotation;
        RaycastHit hit = new RaycastHit();
    }
}
