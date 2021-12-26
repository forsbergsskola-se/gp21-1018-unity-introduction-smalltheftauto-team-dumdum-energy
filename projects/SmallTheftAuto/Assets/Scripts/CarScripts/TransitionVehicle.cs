using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

// TODO: Not sure, if this script is still used? Because the other scripts seem to also implement the logic for entering vehicles
public class TransitionVehicle : MonoBehaviour
{
    [SerializeField] private GameObject player = null;
    [SerializeField] private GameObject car = null;
    public CarMovement movement;
    public Vector3 offSet;
    private float distance;
    private float allowedEnterDistance = 2;

    [SerializeField] private KeyCode enterExitKey = KeyCode.E;
    
     void Start()
     {
         movement.enabled = false;
     }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(player.transform.position, car.transform.position);
        if (distance < allowedEnterDistance)
        {
            GetInNOut();
            if (player.activeSelf == false)
            {
                player.transform.position = car.transform.position + offSet;
            }
        }
    }

    private void GetInNOut()
    {
        if (Input.GetKeyDown(enterExitKey))
        {
            if (!movement.enabled)
            {
                movement.enabled = true;
            }
            else
            {
                movement.enabled = false;
            }
            car.SetActive(car.activeSelf);
            player.SetActive(!player.activeSelf);
            
        }
    }
}
