using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{

    public static int moneyValue = 0;
    Text _money;

   

    void Start()
    {
        _money = GetComponent<Text>();
    }

    void Update()
    {
        _money.text = "Money: " + moneyValue;
    }
    public void SetScore(int money)
    {
        _money.text = "Money: " + money;
    }
}
