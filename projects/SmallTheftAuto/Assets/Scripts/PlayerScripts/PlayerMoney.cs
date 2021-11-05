using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoney : MonoBehaviour
{
    private int playerMoney = 0;

    // Update is called once per frame
    void Update()
    {
        Debug.Log(playerMoney);
    }

    public void Give(int amount)
    {
        playerMoney += amount;
    }
}
