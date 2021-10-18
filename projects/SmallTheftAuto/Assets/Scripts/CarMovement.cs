using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public float speed = 150.0f;
    public float rotationSpeed = 10.0f;

    private Rigidbody bil;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bil = GetComponent<Rigidbody>();
        float force = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;

        // Make it move 10 meters per second instead of 10 meters per frame...
        force *= Time.deltaTime;
        rotation *= Time.deltaTime;

        // Move translation along the z-axis
        bil.AddRelativeForce(0,0,force);

        // Rotate around our y-axis
        if(bil.velocity.z>0)
         transform.Rotate(0, rotation, 0);
    }
}
