using System;
using UnityEngine;

namespace CarScripts
{
    public class Vehicle : MonoBehaviour
    {
        private Driver driver;
        public GameObject player;

        private void Update()
        {
            if (Input.GetButtonDown("Interact-Vehicle"))
            {
               
                    if (!PlayerIsInCar())
                    {
                    
                    if (IfPlayerIsClosetoCar())
                        {
                            EnterCar(GetComponent<Driver>());
                        }
                    }
                    else
                    {
                        ExitCar();
                    }
                }
            
           /* if (Input.GetButtonDown("Interact-Vehicle"))
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
           if (distance < 7)
           {
               vehicle.EnterCar(GetComponent<Driver>());
               
           }*/
                //Driver.Cs update körs före Vehicle.cs Update När man är utanför bilen
                //Debug.Log(GetComponent<Driver>());
                /*if (driver != null)
                {
                    LeaveCar();
                }
                if (GetComponent<CarHealth>().KillCar())
                {
                    GetComponent<Player>().currentHealth = 0;
                    Debug.Log(GetComponent<Player>().currentHealth);
                }
            }*/
        }
        /*void LeaveCar()
        {
            driver.gameObject.transform.position = transform.position + new Vector3(0,0,2);
            driver.gameObject.SetActive(true);
            driver = null;
            GetComponent<CarMovement>().enabled = false;
            

        }
        
        public void EnterCar(Driver driver)
        {
            this.driver = driver;
            GetComponent<Driver>();
            driver.gameObject.SetActive(false);
            GetComponent<CarMovement>().enabled = true;
        }*/

        private bool IfPlayerIsClosetoCar()
        {
            return Vector3.Distance(this.player.transform.position, this.transform.position) < 7;
        }

        private bool PlayerIsInCar()
        {
            return !this.player.activeInHierarchy;
        }

        private void ExitCar()
        {
            this.player.transform.position = this.transform.position + new Vector3(0, 0, 2);
            this.player.SetActive(true);
            GetComponent<CarMovement>().enabled = false;
        }

        private void EnterCar(Driver driver)
        {
            this.player.SetActive(false);
            GetComponent<CarMovement>().enabled = true;
        }
    }
}