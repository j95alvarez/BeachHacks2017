using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Script that makes the camera follow the player
public class CameraController : MonoBehaviour
{
    public GameObject player;  // The player that the camera will follow
    private Vector3 offset;

    // Use this for initialization
    void Start()
    {
        // Set the camera position to where the player currently is
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -10);
        // offset = The Camera position - Player position
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
