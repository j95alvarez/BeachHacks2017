using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barbedWireScript : MonoBehaviour {
	public float oldSpeed;
	public float newSpeed = 0.5f;
	// Use this for initialization
	void Start () {
		GameObject theEnemy = GameObject.Find("Enemy");
		EnemyScript enScript = theEnemy.GetComponent<EnemyScript>();
		oldSpeed = enScript.MoveSpeed;
	}
	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.tag == "Enemy") {
			other.gameObject.GetComponent<EnemyScript> ().MoveSpeed = newSpeed;
		} 
	}
	void OnTriggerExit2D(Collider2D other)
	{
		if (other.gameObject.tag == "Enemy") {
			other.gameObject.GetComponent<EnemyScript> ().MoveSpeed = oldSpeed;
		}
	}
	// Update is called once per frame
	void Update () {
	}
}
