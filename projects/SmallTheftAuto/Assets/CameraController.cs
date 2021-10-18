using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Camera player;
    // Update is called once per frame
    void Update()
    {
        player.transform.position = Vector3.Lerp(player.transform.position, transform.position, 1);
    }
}
