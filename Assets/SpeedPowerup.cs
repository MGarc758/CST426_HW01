using System;
using System.Collections;
using System.Collections.Generic;
using Platformer.Mechanics;
using UnityEngine;

public class SpeedPowerup : MonoBehaviour
{
   private PlayerController player;

   private void OnTriggerEnter2D(Collider2D other)
   {
      if (other.gameObject.name.Equals("Player"))
      {
         player = other.gameObject.GetComponent<PlayerController>();
         player.maxSpeed = 7f;
         this.gameObject.GetComponent<Renderer>().enabled = false;
         
         Invoke(nameof(ResetPlayerSpeed), 7f);
      }
   }

   private void ResetPlayerSpeed()
   {
      player.maxSpeed = 3f;
      Destroy(this.gameObject);
   }
}
