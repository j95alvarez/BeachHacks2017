using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour {
    public GameObject Enemy;
    public float numEnemy;
    public float startTime;
    public float waitTime;

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
                Instantiate(Enemy, transform.position, Quaternion.identity);

            }

            yield return new WaitForSeconds (waitTime);
        }
    }
}
