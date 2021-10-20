using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleJD : MonoBehaviour
{
    public GameObject player;

    public CarMovementJD carMovement;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
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
        carMovement.enabled = false;
    }

    void EnterCar()
    {
        player.SetActive(false);
        carMovement.enabled = true;
    }
}
