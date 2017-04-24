using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour {
    public GameObject enemy, temp;
    public float numEnemy;
    public float startTime;
    public float waitTime;
    public GameObject manager;
    public int count;
    public bool canSpawn;


    public float timeToSpawn;

    [SerializeField]
    private float timer;
    // Use this for initialization
    void Start()
    {
        timer = 0;
        canSpawn = true;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if ((timer >= timeToSpawn) && canSpawn && (count < 5))
        {
            timer = 0;
            count++;
            Instantiate(enemy, gameObject.transform.position, Quaternion.identity);
            //temp.gameObject.name = "Enemy";
            manager.gameObject.GetComponent<SpawnController>().counter++;
            Debug.Log("Enemy Spawned!");
        }
    }


    /*
    // Use this for initialization
    void Start()
    {
        canSpawn = true;
        count = 0;
        //StartCoroutine(SpawnWaves());
    }

     void Update()
    {
        if (canSpawn)
            StartCoroutine(SpawnWaves());
    }

    IEnumerator SpawnWaves()
    {
        while (true)
        {
            count++;
            for (int i = 0; i < numEnemy; i++)
            {
                temp = Instantiate(Enemy, transform.position, Quaternion.identity);
                temp.gameObject.name = "Enemy" + count;
                manager.gameObject.GetComponent<SpawnController>().counter++;
                Debug.Log("Enemy Spawned!");

            }

            yield return new WaitForSeconds(waitTime);
        }
    }*/
}
