using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPPoint : MonoBehaviour
{
    // TODO: Good!
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.GetComponent<Player>().CurrentHealth += 20;
            Destroy(gameObject);
        }
    }
}
