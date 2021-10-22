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
                if (driver != null)
                {
                    LeaveCar();
                }
            }
        }

        void LeaveCar()
        {
            driver.gameObject.transform.position = transform.position + new Vector3(0,0,2);
            driver.gameObject.SetActive(true);
            driver = null;
            GetComponent<CarMovement>().enabled = false;
        }

        // ReSharper disable Unity.PerformanceAnalysis
        public void EnterCar(Driver driver)
        {
            this.driver = driver;
            GetComponent<Driver>();
            driver.gameObject.SetActive(false);
            GetComponent<CarMovement>().enabled = true;
        }
    }
}