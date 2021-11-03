using System.Collections;
using System.Collections.Generic;
using CarScripts;
using Unity.VisualScripting;
using UnityEngine;

public class Driver : MonoBehaviour
{
    //private Driver driver; //används aldrig så kommenterade ut den
    // Update is called once per frame
    void Update()
    {
           var vehicles = FindObjectsOfType<Vehicle>(); //findObjectsOfType to find them all, then measure distance.
            if(vehicles.Length == 0)
            {
                return;
            }
            var vehicle = vehicles[0];
            float distance = Vector3.Distance(this.transform.position, vehicle.transform.position);
            foreach (var v in vehicles)
           {
               if(Vector3.Distance(transform.position, v.transform.position) < distance)
               {
                   vehicle = v;
                   distance = Vector3.Distance(transform.position, vehicle.transform.position);
               }
           }
    }
}
