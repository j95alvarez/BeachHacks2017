using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour {
    public GameObject spawn1;
    public GameObject spawn2;
    public int counter = 0;

    // Use this for initialization
    void Start()
    {
        //spawn1.gameObject.SetActive(true);
        //spawn2.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        // Deactivates both spawners when there are 10 enemies
        if (counter >= 10)
        {
            spawn1.gameObject.GetComponent<SpawnerScript>().canSpawn = false;
            spawn2.gameObject.GetComponent<SpawnerScript>().canSpawn = false;
        }
        else
        {
            // Checks to see if both spawners can spawn and they cant, activate them
            if (!spawn1.gameObject.GetComponent<SpawnerScript>().canSpawn && !spawn2.gameObject.GetComponent<SpawnerScript>().canSpawn)
            {
                spawn1.gameObject.GetComponent<SpawnerScript>().canSpawn = true;
                spawn2.gameObject.GetComponent<SpawnerScript>().canSpawn = true;

                spawn1.gameObject.GetComponent<SpawnerScript>().count = 0;
                spawn2.gameObject.GetComponent<SpawnerScript>().count = 0;
            }
        }
    }
}
