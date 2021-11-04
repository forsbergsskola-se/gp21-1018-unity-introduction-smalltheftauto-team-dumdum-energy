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

    void QuestRequirement()//here goes logic for the quest, kill people or arrive at a position maybe?
    {
        if (this.transform.position == new Vector3(63.56453,0,-6.910467))
        {
            requirement = true;
        }
    }
}

