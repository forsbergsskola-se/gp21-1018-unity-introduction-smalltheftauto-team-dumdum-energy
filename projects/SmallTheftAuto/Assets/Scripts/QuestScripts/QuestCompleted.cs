using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestCompleted : MonoBehaviour
{
    private QuestGiver _questGiver;
    private bool questStatus;
    public bool requirement;

    private void Start()
    {
         questStatus = FindObjectOfType<QuestGiver>().isOnQuest;
    }

    private void Update()
    {
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
      FindObjectOfType<Player>().GetComponent<Player>().MoneyKeeper += 50;
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
        if (other.gameObject.CompareTag("Player") && FindObjectOfType<QuestGiver>().isOnQuest)
        {
            requirement = true;
            GivePlayerMoney();
            Debug.Log("Quest complete");
        }
    }
}

