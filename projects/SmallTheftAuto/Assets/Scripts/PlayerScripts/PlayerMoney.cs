using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMoney : MonoBehaviour
{
    public int playerMoney = 0;
    private Text scoreTxt;

    // Update is called once per frame
    

    public void Give(int amount)
    {
        playerMoney += amount;
    }
}
