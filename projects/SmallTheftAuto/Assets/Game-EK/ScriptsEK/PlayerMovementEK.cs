using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementEK : MonoBehaviour
{
    public float speed = 10.0f;
    public float rotationSpeed = 100.0f;

   // Animator m_Animator;
    // Start is called before the first frame update
    void Start()
    {
      //  m_Animator = gameObject.GetComponent<Animator>();
    }

    private void Update()
    {
       /* if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            m_Animator.ResetTrigger("Stand");
            m_Animator.SetTrigger("Walk");
        }

        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.D))
        {

            m_Animator.ResetTrigger("Walk");
            m_Animator.SetTrigger("Stand");
        }*/

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Get the horizontal and vertical axis.
        // By default they are mapped to the arrow keys.
        // The value is in the range -1 to 1
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;

        // Make it move 10 meters per second instead of 10 meters per frame...
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;

        // Move translation along the object's z-axis
        transform.Translate(0, 0, translation);

        // Rotate around our y-axis
        transform.Rotate(0, rotation, 0);
    }
}
