using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class storeScript : MonoBehaviour {
	public Transform storeMenu;
    public GameObject player;
    
    // Use this for initialization
	void Start () {
        Time.timeScale = 1;
        storeMenu.gameObject.SetActive(false);
	}

	public void TBought(){
        if (player != null)
            player.gameObject.GetComponent<Player>().hasTurret = true;
        Debug.Log("Player now has turrets");
	}
	public void BWBought(){
        if (player != null)
            player.gameObject.GetComponent<Player>().hasWire = true;
        Debug.Log("Player now has barbed wire");
    }
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!storeMenu.gameObject.active)
            {
                Time.timeScale = 0;
                storeMenu.gameObject.SetActive(true);
                player.gameObject.SetActive(false);
            }
            else
            {
                Time.timeScale = 1;
                storeMenu.gameObject.SetActive(false);
                player.gameObject.SetActive(true);
            }

        }
    }
}
