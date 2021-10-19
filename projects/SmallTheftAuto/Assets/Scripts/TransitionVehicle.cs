using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionVehicle : MonoBehaviour
{
    [SerializeField] private GameObject player = null;
    [SerializeField] private GameObject car = null;

    [SerializeField] private KeyCode enterExitKey = KeyCode.E;
    
     void Start()
     {
        car.SetActive(!car.GetComponent<CarMovement>());  
     }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(enterExitKey))
        {
            car.SetActive(car.activeSelf);
            player.SetActive(!player.activeSelf);
        }
    }
}
