using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class QuestButtons : MonoBehaviour
{
   private Button accept;
   private Button deny;
   private Button x;
   private Button[] buttons;


   void SetButtons()
   {
      buttons = GetComponentsInChildren<Button>();
      foreach (var VARIABLE in buttons)
      {
         if (VARIABLE.name == "Accept" )
         {
            accept = VARIABLE;
            accept.onClick.AddListener(Accept);
         }

         if (VARIABLE.name == "Deny")
         {
            deny = VARIABLE;
            deny.onClick.AddListener(Deny);
         }

         if (VARIABLE.name == "Exit")
         {
            x = VARIABLE;
            x.onClick.AddListener(Deny);
         }
      }
   }

   private void Update()
   {
      SetButtons();
   }

   public void Accept()
   {
      FindObjectOfType<QuestGiver>().isOnQuest = true;
      GetComponent<Canvas>().enabled = false;
   }

   public void Deny()
   {
      GetComponent<Canvas>().enabled = false;
   }
}
