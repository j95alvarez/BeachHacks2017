using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public GameObject house;            //The house
    public GameObject enemySpawner;     //The spanwer controller object
    public float MoveSpeed;             //Movement speed of the enemy
    public const float maxHp = 20;      //The max amount of hp for the enemy
    public float hp;                    //The current hp of the enemy
    private bool enable;                //Check to see if a certain amount of time has passed

    // Use this for initialization
    void Start()
    {
        house = GameObject.FindGameObjectWithTag("House");      //Find the house in the game
        enemySpawner = GameObject.FindGameObjectWithTag("EnemySpawner");
        Debug.Log(house.tag);
        hp = maxHp;             //Set current hp to max hp
        enable = true;          //Set enable to true
    }

    // Update is called once per frame
    void Update()
    {
        if (house != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, house.transform.position, MoveSpeed * Time.deltaTime);     //Moves enemies toward the house
        }

        if (hp <= 0)
        {
            enemySpawner.gameObject.GetComponent<SpawnController>().counter--;
            Destroy(gameObject);            //If enemy hp <= 0, destroy the enemy
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "House")
        {
            collision.gameObject.GetComponent<HouseScript>().hp--;          //If the enemy hits the house, deal damage to the house
        }
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Player>().hp--;               //If the enemy hits the player, deal damage to the player
        }
    }

    IEnumerator OnCollisionStay2D(Collision2D collision)
    {
        if (enable)
        {
            if (collision.gameObject.tag == "House")
            {
                collision.gameObject.GetComponent<HouseScript>().hp--;          //If enable is true, deal damage to house if enemy is touching the house
            }
            if (collision.gameObject.tag == "Player")
            {
                collision.gameObject.GetComponent<Player>().hp--;               //If enable is true, deal damage to player if enemy is touching the player
            }
            enable = false;
            yield return new WaitForSeconds(2);                 //Wait for two seconds
            enable = true;
        }

    }

}
