using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Creates new PlayerHealthOR and set 100hp as value for hp
        PlayerHealthOR healthPoints = new PlayerHealthOR(100);
        //displays message of how much hp character has
        Debug.Log($"Health: {healthPoints.GetHealth()}");
    }

    // Update is called once per frame
   
}
