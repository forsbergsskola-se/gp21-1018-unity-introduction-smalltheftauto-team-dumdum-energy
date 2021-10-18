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
            transform.Translate(0f, 0.01f, 0f);  
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0);
        }
        
    }
}
