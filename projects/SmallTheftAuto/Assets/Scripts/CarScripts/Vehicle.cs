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
                if (!PlayerIsInCar())
            {
                if (IsPlayerNearCar())
                {
                    EnterCar();
                }
                
            }
            else
            {
                LeaveCar();
            }
        }
        }
        bool PlayerIsInCar()
        {
            return !this.player.activeInHierarchy;
        }


        public void LeaveCar()
        {
            player.transform.position = GetComponent<Transform>().position;
            player.SetActive(true);
            GetComponent<CarMovement>().enabled = false;
        }

        public void EnterCar()
        {
            player.SetActive(false);
            GetComponent<CarMovement>().enabled = true;
        }
        bool IsPlayerNearCar()
        {
            return Vector3.Distance(this.player.transform.position, this.transform.position) < 1;
        }
    }
}