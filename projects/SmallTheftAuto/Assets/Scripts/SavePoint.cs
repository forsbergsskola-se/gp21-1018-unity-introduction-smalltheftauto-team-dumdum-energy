using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class SavePoint : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        
    }
   void OnTriggerEnter(Collider other)
    {
          SaveSystem.SavePlayer(FindObjectOfType<Player>());  
    }
}
