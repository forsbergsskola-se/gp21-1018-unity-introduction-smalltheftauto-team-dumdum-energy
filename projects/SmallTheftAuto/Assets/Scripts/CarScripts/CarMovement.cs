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
        float velocity = bil.velocity.magnitude;
        // Make it move 10 meters per second instead of 10 meters per frame...
        force *= Time.deltaTime;
        rotation *= Time.deltaTime;

        // TODO: I like that you implemented physical movement here. Unfortunately, I cannot test this.
        // Move translation along the z-axis
        bil.AddRelativeForce(0,0,force);

        // Rotate around our y-axis
        if(bil.velocity.x >0.1 | bil.velocity.z >0.1 | bil.velocity.x <-0.1 | bil.velocity.z <-0.1)
         transform.Rotate(0, rotation, 0);
    }
}
