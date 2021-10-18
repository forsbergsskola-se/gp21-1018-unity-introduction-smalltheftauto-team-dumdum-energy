using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthOR : MonoBehaviour
{
    private int health;

    public PlayerHealthOR(int health)
    {
        this.health = health;
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
