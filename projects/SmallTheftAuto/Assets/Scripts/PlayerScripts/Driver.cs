using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Driver : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Interact-Vehicle"))
        {
           var vehicle = FindObjectOfType<TransitionVehicle>(); //findObjectsOfType to find them all, then measure distance.
           TransitionVehicle.Enter(driver);
        }
    }

    void Enter(Driver driver)
    {
        driver.enabled = false;
        var movement = vehicle.GetComponent<CarMovement>();
        movement.enabled = true;

    }

    void Leave()
    {
        Driver.transform.position = vehicle.transform.position;
        Driver.enabled = true;
        _driver = null;
        vehicle.GetComponent<CarMovement>().enabled = false;
    } 
}
