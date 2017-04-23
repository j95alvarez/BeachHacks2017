using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour {
    public GameObject Enemy;        //The enemy
    public float numEnemy;          //The number of enemies
    public float startTime;         //The start time
    public float waitTime;          //The amount of time that has gone by

	// Use this for initialization
	void Start () {
        StartCoroutine(SpawnWaves());
	}
	

    IEnumerator SpawnWaves()
    {
        while(true)
        {
            for(int i = 0; i < numEnemy; i++)
            {
                Instantiate(Enemy, transform.position, Quaternion.identity);        //Creates enemies
                Debug.Log("Enemy Spawned!");

            }

            yield return new WaitForSeconds (waitTime);
        }
    }
}
