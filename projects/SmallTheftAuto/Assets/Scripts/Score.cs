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
        
    }

    void Update()
    {
        _score.text = "Score: " + scoreValue;
    }
    public void SetScore(int score)
    {
        _score = GetComponent<Text>();
        _score.text = "Score: " + score;
    }
}
