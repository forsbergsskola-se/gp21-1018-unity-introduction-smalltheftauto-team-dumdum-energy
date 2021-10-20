using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleEK : MonoBehaviour
{
    public GameObject player;
    public CarMovementEK carMovementEK;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            if (!PlayerIsInCar())
            {
                if (IfPlayerIsClosetoCar())
                {
                    EnterCar();
                }
            }
            else
            {
                ExitCar();
            }
        }
    }

    private bool IfPlayerIsClosetoCar()
    {
        return Vector3.Distance(this.player.transform.position, this.transform.position) < 1;
    }

    private bool PlayerIsInCar()
    {
        return !this.player.activeInHierarchy;
    }

    private void ExitCar()
    {
        this.player.transform.position = this.transform.position;
        this.player.SetActive(true);
        this.carMovementEK.enabled = false;
    }

    private void EnterCar()
    {
        this.player.SetActive(false);
        this.carMovementEK.enabled = true;
    }
}
