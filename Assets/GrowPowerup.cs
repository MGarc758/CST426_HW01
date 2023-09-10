using System;
using System.Collections;
using System.Collections.Generic;
using Platformer.Mechanics;
using Unity.VisualScripting;
using UnityEngine;

public class GrowPowerup : MonoBehaviour
{
    private GameObject player;
    private PlayerController pc;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name.Equals("Player"))
        {
            player = other.gameObject;
            player.transform.localScale = new Vector3(2, 2, 2);
            
            pc = player.GetComponent<PlayerController>();
            pc.maxSpeed = 6;
            
            this.gameObject.GetComponent<Renderer>().enabled = false;
            
            Invoke(nameof(ResetPlayerSize), 10f);
        }
    }

    private void ResetPlayerSize()
    {
        player.transform.localScale = new Vector3(1, 1, 1);
        pc.maxSpeed = 3;
        Destroy(this.gameObject);
    }
}
