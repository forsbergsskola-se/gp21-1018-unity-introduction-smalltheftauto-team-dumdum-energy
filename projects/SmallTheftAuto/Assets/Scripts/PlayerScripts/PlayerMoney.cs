using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMoney : MonoBehaviour
{
    public int playerMoney;
    private Text scoreTxt;

    // Update is called once per frame
    
    // TODO: Nice framework, lack of time, I guess?
    public void Give(int amount)
    {
        playerMoney += amount;
    }
}
