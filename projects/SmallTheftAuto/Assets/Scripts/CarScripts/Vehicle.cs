using System;
using UnityEngine;

namespace CarScripts
{
    public class Vehicle : MonoBehaviour
    {
        public GameObject player;
        private void Update()
        {
            float distance = Vector3.Distance(player.transform.position, gameObject.transform.position);
            if (Input.GetButtonDown("Interact-Vehicle"))
            {
                if (IsInCar())
                {
                    LeaveCar();
                }
                else if(distance < 10)
                {
                    EnterCar(); 
                }
            
            }
        }
        bool IsInCar()
        {
            return !player.activeInHierarchy;
        }

        void LeaveCar()
        {
            player.transform.position = GetComponent<Transform>().position;
            player.SetActive(true);
            GetComponent<CarMovementJD>().enabled = false;
        }

        void EnterCar()
        {
            player.SetActive(false);
            GetComponent<CarMovementJD>().enabled = true;
        }
    }
}