﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {
    public GameObject player;
    public float MoveSpeed;
    public const float maxHp = 20;
    public float hp;

    // Use this for initialization
    void Start() {
        player = GameObject.FindGameObjectWithTag("Player");
        hp = maxHp;
    }
    
    // Update is called once per frame
    void Update() {
        if (player != null) {
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, MoveSpeed * Time.deltaTime);
        }

        if (hp <= 0) {
            Destroy(gameObject);
        }
    }

}
