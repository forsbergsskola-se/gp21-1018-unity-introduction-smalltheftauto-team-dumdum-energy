using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownPlayerMovement : MonoBehaviour
{
    private InputHandler _input;

    private void Awake()
    {
        _input = GetComponent<InputHandler>();
    }
    
    
    void Update()
    {
        var targetVector = new Vector3(_input.InputVector.x, 0, _input.InputVector.y);
        // Move in aim direction
        // rotate in travel direction
    }
}
