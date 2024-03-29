using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VeichleOR : MonoBehaviour
{
 
    public GameObject playerOR;
    public CarMovementOR carMovementOR;
    
 
    void Update()
    {
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

    bool IsPlayerNearCar()
    {
        return Vector3.Distance(this.playerOR.transform.position, this.transform.position) < 1;
    }

    bool PlayerIsInCar()
    {
        return !this.playerOR.activeInHierarchy;
    }
    

    private void EnterCar()
    {
        this.playerOR.SetActive(false);
        GetComponent<CarMovementOR>().enabled = true;
    }
    
    private void LeaveCar()
    {
        this.playerOR.transform.position = this.transform.position;
        this.playerOR.SetActive(true);
        this.carMovementOR.enabled = false;
    }
}
