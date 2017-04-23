using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScript : MonoBehaviour {
	public const float maxHp = 20;
	public float hp;
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		Debug.Log (player.tag);
		hp = maxHp;
	}
	public GameObject player;
	public float MoveSpeed = 1;
	int maxDist = 10;
	int minDist = 2;
	// Update is called once per frame
	void Update () {
		if (player!=null) {
			transform.position = Vector3.MoveTowards(transform.position, player.transform.position, MoveSpeed * Time.deltaTime);
		}
		if (hp <= 0) {
			Destroy (gameObject);
		}
	}
}
