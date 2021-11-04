using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestCompleted : MonoBehaviour
{
    private QuestGiver _questGiver;
    private bool questStatus;
    private bool requirement;

    private void Start()
    {
         questStatus = FindObjectOfType<QuestGiver>().isOnQuest;
    }

    private void Update()
    {
        {
            
        }
        if (questStatus)
        {
            if (CompleteQuest())
            {
                GivePlayerMoney();
            }
        }
    }

    private void GivePlayerMoney()
    {
        FindObjectOfType<Player>().GetComponent<PlayerMoney>().Give();
    }

    bool CompleteQuest()
    {
        if (requirement)
        {
            return true;
        }
        return false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            requirement = true;
            Debug.Log("Quest complete");
        }
    }
}

