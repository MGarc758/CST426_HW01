using System;
using System.Collections;
using System.Collections.Generic;
using Platformer.Mechanics;
using UnityEngine;

public class ShrinkPowerup : MonoBehaviour
{
    private GameObject player;
    private PlayerController pc;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name.Equals("Player"))
        {
            player = other.gameObject;
            pc = player.GetComponent<PlayerController>();
            pc.maxSpeed = 10f;

            player.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            this.gameObject.GetComponent<Renderer>().enabled = false;
            Invoke(nameof(ResetChanges), 10f);
        }
    }

    private void ResetChanges()
    {
        pc.maxSpeed = 3f;
        player.transform.localScale = new Vector3(1, 1, 1);
        Destroy(this.gameObject);
    }
}
