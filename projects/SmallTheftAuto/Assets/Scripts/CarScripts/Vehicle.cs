using System;
using UnityEngine;

namespace CarScripts
{
    public class Vehicle : MonoBehaviour
    {
        private Driver driver;

        private void Update()
        {
            if (Input.GetButtonDown("Interact-Vehicle"))
            {
               
                //Driver.Cs update körs före Vehicle.cs Update När man är utanför bilen
                //Debug.Log(GetComponent<Driver>());
                if (driver != null)
                {
                    LeaveCar();
                }
                if (GetComponent<CarHealth>().KillCar())
                {
                    GetComponent<Player>().CurrentHealth -= 50;
                    Debug.Log("Player Health: " + GetComponent<Player>().CurrentHealth);
                }
            }
        }
        void LeaveCar()
        {
            driver.gameObject.transform.position = transform.position + new Vector3(0, 0, 2);
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
        }
    }
}