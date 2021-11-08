using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{

  // public static int moneyValue = 0;
    Text _money;

   

    public void SetScore(int money) //TODO: this should be called SetMoney?
    {
        _money = GetComponent<Text>();
        _money.text = "Money: " + money;
    }
}
