using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementOR : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //only happens if press W
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0.01f, 0f, 0f);  
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-0.01f, 0f, 0f);  
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0f, 0f, 0.2f);
        }
        // First Exercise:
        // make him walk backwards, when S is pressed
        
        // Second Exercise:
        // make him turn left, if A is pressed
        // transform.Rotate(xAngle, yAngle, zAngle);
        // make him turn right, if D is pressed
        
        // Third Exercise:
        // What problem exists again with Update, Movement, Frame-Rate (FPS)?
        
        // Fourth Exercise:
        // Use Input.GetAxis() instead of Input.GetKey(
        
    }
}
