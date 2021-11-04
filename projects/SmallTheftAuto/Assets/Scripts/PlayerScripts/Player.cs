using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    public int maxHealth = 100;
    private int _currentHealth;

    public int CurrentHealth
    {
        set
        {
            _currentHealth = value;
            healthBar.SetHealth(value);
        }
        get => _currentHealth;
    }

    public HealthBar healthBar;
    [SerializeField] private TextMeshPro DeathMessage;


    void Start()
    {
        CurrentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(20);
            Score.scoreValue += 100;
        }

        if (CurrentHealth == 0)
        {
             OnDeath();
        }
    }

    void TakeDamage(int damage)
    {
        CurrentHealth -= damage;
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

         CurrentHealth = data.health;
         

         Vector3 position;
         position.x = data.position[0];
         position.y = data.position[1];
         position.z = data.position[2];
         transform.position = position;
     }
    
}
