using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public HealthBar healthBar;
    [SerializeField] private TextMeshPro DeathMessage;


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
            Score.scoreValue += 100;
        }

        if (currentHealth == 0)
        {
             OnDeath();
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }

    public UnityEvent OnPlayerDeath; 
     public void OnDeath()
     {
         OnPlayerDeath.Invoke();
         Destroy(GameObject.Find("Player"));
     }

     // public void SavePlayer()
     // {
     //     SaveSystem.SavePlayer(this);
     // }

     public void LoadPlayer()
     {
         PlayerData data = SaveSystem.LoadPlayer(FindObjectOfType<Player>());

         currentHealth = data.health;

         Vector3 position;
         position.x = data.position[0];
         position.y = data.position[1];
         position.z = data.position[2];
         transform.position = position;
     }
    
}
