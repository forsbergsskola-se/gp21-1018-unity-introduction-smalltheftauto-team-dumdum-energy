using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour, IEnemy
{
    public float currentHealth, power;
    public float maxHealth;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        if (currentHealth <= 0)
        {
            Die();
            FindObjectOfType<Player>().ScoreKeeper += 500;
            FindObjectOfType<Player>().MoneyKeeper += 500;
        }
    }

    private void Die()
    {
        Destroy(gameObject);
    }

    public void PerformAttack()
    {
        throw new System.NotImplementedException();
    }
}
