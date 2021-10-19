using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthOR : MonoBehaviour
{
    public Slider slider;

    private int health;

    public PlayerHealthOR(int health)
    {
        this.health = health;
        slider.value = health;
    }

    public int GetHealth()
    {
        
        return health;
    }

    public void Damage(int damageTaken)
    {
        health -= damageTaken;
    }

    public void Heal(int healthGranted)
    {
        health += healthGranted;
    }
}
