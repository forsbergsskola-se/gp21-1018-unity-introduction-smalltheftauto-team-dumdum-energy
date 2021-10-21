using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BillboardOR : MonoBehaviour
{
    public Transform cam;
   

    // LateUpdate is called after regular update, camera does movement, then we point towards it
    void LateUpdate()
    {
        //Allows us to point object towards a target. Take current position, and go one unit in direction camera facing
        transform.LookAt(transform.position + cam.forward);
    }
}
