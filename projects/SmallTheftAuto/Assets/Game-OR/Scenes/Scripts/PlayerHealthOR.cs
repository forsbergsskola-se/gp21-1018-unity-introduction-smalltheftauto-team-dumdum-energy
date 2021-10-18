using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthOR
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
}
