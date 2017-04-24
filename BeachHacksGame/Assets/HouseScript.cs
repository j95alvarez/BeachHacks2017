using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseScript : MonoBehaviour {
    public int hp;          //The hp of the house

    // Use this for initialization
    void Start()
    {
        hp = 5;             //Set the hp of the house
    }

    // Update is called once per frame
    void Update()
    {
        if (hp == 0)
        {
            Time.timeScale = 0;         //If the hp of the house hits 0, stop the game
        }
    }
}
