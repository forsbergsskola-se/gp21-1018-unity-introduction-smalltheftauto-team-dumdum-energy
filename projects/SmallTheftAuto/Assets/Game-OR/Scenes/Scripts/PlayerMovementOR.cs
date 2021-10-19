using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementOR : MonoBehaviour
{
    
    public float fast = 15f;
    public float rotateFast = 120f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is now fixed
    void FixedUpdate()
    {
        
        // Grab horizontal and vertical axis, the mapping is by default.
        float translation = Input.GetAxis("Vertical") * fast;
        float rotation = Input.GetAxis("Horizontal") * rotateFast;
        
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
       
        transform.Translate(0, 0, translation);

        transform.Rotate(0, rotation, 0);
    }
    
}
