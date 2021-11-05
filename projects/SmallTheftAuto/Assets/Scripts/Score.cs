using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public static int scoreValue = 0;
    Text _score;

   

    void Start()
    {
        _score = GetComponent<Text>();
    }

    void Update()
    {
        _score.text = "Score: " + scoreValue;
    }
    public void SetScore(int score)
    {
        _score.text = "Score: " + score;
    }
}
