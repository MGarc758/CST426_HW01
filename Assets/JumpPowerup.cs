using System;
using System.Collections;
using System.Collections.Generic;
using Platformer.Mechanics;
using SerializableCallback;
using UnityEngine;

public class JumpPowerup : MonoBehaviour
{
    private PlayerController player;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name.Equals("Player"))
        {
            player = other.gameObject.GetComponent<PlayerController>();
            player.jumpTakeOffSpeed = 12f;
            player.gravityModifier = 1.25f;
            
            this.gameObject.GetComponent<Renderer>().enabled = false;
            Invoke(nameof(ResetJumpSpeed), 7);
        }
    }

    private void ResetJumpSpeed()
    {
        player.jumpTakeOffSpeed = 7f;
        player.gravityModifier = 1;
        Destroy(this.gameObject);
    }
}
