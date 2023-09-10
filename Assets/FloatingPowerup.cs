using System;
using System.Collections;
using System.Collections.Generic;
using Platformer.Mechanics;
using UnityEngine;

public class FloatingPowerup : MonoBehaviour
{
    private PlayerController player;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name.Equals("Player"))
        {
            player = other.gameObject.GetComponent<PlayerController>();
            player.gravityModifier = 0.5f;
            player.jumpTakeOffSpeed = 12f;

            this.gameObject.GetComponent<Renderer>().enabled = false;
            Invoke(nameof(ResetGravity), 15f);
        }
    }

    private void ResetGravity()
    {
        player.gravityModifier = 1f;
        player.jumpTakeOffSpeed = 7f;
        Destroy(this.gameObject);
    }
}
