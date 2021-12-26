using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestGiver : MonoBehaviour
{
    

    public bool isOnQuest;
    private bool accepted;

    Player player;
    Canvas[] canvas;
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Player>();
        canvas = FindObjectsOfType<Canvas>();
    }

    // Update is called once per frame
    void Update()
    {
        Quest();
        if (FindObjectOfType<QuestCompleted>().requirement)
        {
            isOnQuest = false;
        }
    }

    // TODO: Name `StartQuest`, maybe?
    void Quest()
    {
        var distance = Vector3.Distance(player.transform.position, transform.position);
        if (distance < 5 && Input.GetButtonDown("Interact-Vehicle"))
        {
            if (isOnQuest)
            {
                return;
            }

            if (!isOnQuest)
            {
                // TODO: Fix variable name
                foreach (var VARIABLE in canvas)
                {
                    if (VARIABLE.name == "QuestCanvas")
                    {
                        GameObject canvas = VARIABLE.gameObject;
                        canvas.GetComponent<Canvas>().enabled = true;
                    }
                }
                //open up a dialog where quest is presented, es and no button. yes = accepted
                if (accepted)
                {
                    isOnQuest = true;
                    
                }
            }
        }
    }
}
