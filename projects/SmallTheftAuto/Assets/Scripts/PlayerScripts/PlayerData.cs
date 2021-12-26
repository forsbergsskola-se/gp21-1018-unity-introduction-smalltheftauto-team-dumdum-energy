using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// TODO: Good!
[System.Serializable]
public class PlayerData
{
   public int health;
   public int score;
   public int money;
   public float[] position;

   public PlayerData(Player player)
   {
      health = player.CurrentHealth;
      score = player.ScoreKeeper;
      money = player.MoneyKeeper;
      position = new float[3];
      position[0] = player.transform.position.x;
      position[1] = player.transform.position.y;
      position[2] = player.transform.position.z;
   }
}
