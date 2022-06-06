using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
   public bool isPlayer1goal;

   private void OnTriggerEnter2D(Collider2D collision)
   {
      if (collision.gameObject.CompareTag("Pong"))
      {
         if (!isPlayer1goal)
         {
            Debug.Log("Player 1 Scored...");
            GameObject.Find("GameManager").GetComponent<GameManager>().Player1Scored();
         }
         else
         {
            Debug.Log("Player 2 Scored...");
            GameObject.Find("GameManager").GetComponent<GameManager>().Player2Scored();
         }
         
      }
   }
}
