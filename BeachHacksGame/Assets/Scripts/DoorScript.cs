using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour {

    public Transform destination;
    public GameObject player;


    //private void OnTriggerEnter2D(Collider2D player)
    private void OnTriggerEnter2D(Collider2D player)
    {
        player.transform.position = destination.position;  
    }
}
