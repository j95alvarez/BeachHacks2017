using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour {
    public GameObject Enemy;
    public float numEnemy;
    public float startTime;
    public float waitTime;
	public GameObject manager;

	// Use this for initialization
	void Start () {
        StartCoroutine(SpawnWaves());
	}

//	void Update() {
//		while(true)
//		{
//			for(int i = 0; i < numEnemy; i++)
//			{
//				Instantiate(Enemy, transform.position, Quaternion.identity);
//				manager.gameObject.GetComponent<levelManager> ().enemey_counter++;
//				Debug.Log("Enemy Spawned!");
//
//			}
//
//			//yield return new WaitForSeconds (waitTime);
//		}
//	}

    IEnumerator SpawnWaves()
    {
        while(true)
        {
            for(int i = 0; i < numEnemy; i++)
            {
                Instantiate(Enemy, transform.position, Quaternion.identity);
				manager.gameObject.GetComponent<SpawnerControl> ().counter++;
                Debug.Log("Enemy Spawned!");

            }

            yield return new WaitForSeconds (waitTime);
        }
    }
}
