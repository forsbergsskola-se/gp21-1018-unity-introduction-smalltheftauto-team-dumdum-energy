using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestGiver : MonoBehaviour
{
    

    private bool isOnQuest;
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
    }

    void Quest()
    {
        var distance = Vector3.Distance(player.transform.position, transform.position);
        if (distance < 2 && Input.GetButtonDown("Interact-Vehicle"))
        {
            if (isOnQuest)
            {
                return;
            }

            if (!isOnQuest)
            {
                foreach (var VARIABLE in canvas)
                {
                    if (VARIABLE.name == "QuestCanvas")
                    {
                        GameObject canvas = VARIABLE.gameObject;
                        canvas.SetActive(true);     
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
