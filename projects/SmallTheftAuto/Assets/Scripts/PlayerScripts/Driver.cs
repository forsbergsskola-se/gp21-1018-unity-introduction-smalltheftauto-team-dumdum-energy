using System.Collections;
using System.Collections.Generic;
using CarScripts;
using Unity.VisualScripting;
using UnityEngine;

public class Driver : MonoBehaviour
{
    private Driver driver;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Interact-Vehicle"))
        {
           var vehicles = FindObjectsOfType<Vehicle>(); //findObjectsOfType to find them all, then measure distance.
           var vehicle = vehicles[0];
           float distance = Vector3.Distance(this.transform.position, vehicle.transform.position);
           if (driver != null)
           {
               Leave();
           }
           else if (distance < 10)
           {
               vehicle.Enter(this);
           }
        }
        
    }

    void Enter(Vehicle vehicle)
    {
        driver = this;
        driver.enabled = false;
        var movement = vehicle.GetComponent<CarMovement>();
        movement.enabled = true;

    }

    void Leave()
    {
        driver.transform.position = vehicle.transform.position;
        driver.enabled = true;
        driver = null;
        var movement = vehicle.GetComponent<CarMovement>();
        movement.enabled = false;
    } 
}
