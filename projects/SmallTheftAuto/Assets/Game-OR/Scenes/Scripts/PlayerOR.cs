using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOR : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public HealthBarOR healthBar;

    
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(20);
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }
}
