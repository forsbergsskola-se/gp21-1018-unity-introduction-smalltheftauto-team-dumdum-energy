using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    public int maxHealth = 100;
    private int _currentHealth;
    private int _currentScore;
    private int _currentMoney;

    public int CurrentHealth
    {
        set
        {
            _currentHealth = value;
            healthBar.SetHealth(value);
        }
        get => _currentHealth;
    }

    public int ScoreKeeper
    {
        set
        {
            _currentScore = value;
            scoreValue.SetScore(value);
        }
        get => _currentScore;
    }
    public int MoneyKeeper
    {
        set
        {
            _currentMoney = value;
            moneyValue.SetScore(value);
        }
        get => _currentMoney;
    }

    public HealthBar healthBar;
    public Score scoreValue;
    public Money moneyValue;
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
            ScoreKeeper += 100;
            MoneyKeeper += 9000;
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
    public UnityEvent OnPlayerEnterSave;
    public UnityEvent OnPlayerExitSave;
     public void OnDeath()
     {
         OnPlayerDeath.Invoke();
         Destroy(GameObject.Find("Player"));
     }

     private void OnTriggerExit(Collider other)
     {
         if (other.tag == "SavePoint")
         {
             OnPlayerExitSave.Invoke();
         }
     }

     private void OnTriggerEnter(Collider other)
     {
         if (other.tag == "SavePoint")
         {
             OnPlayerEnterSave.Invoke();
         }
     }

     public void LoadPlayer()
     {
         PlayerData data = SaveSystem.LoadPlayer(FindObjectOfType<Player>());

         CurrentHealth = data.health;
         ScoreKeeper = data.score;
         MoneyKeeper = data.money;
         

         Vector3 position;
         position.x = data.position[0];
         position.y = data.position[1];
         position.z = data.position[2];
         transform.position = position;
     }
    
}
