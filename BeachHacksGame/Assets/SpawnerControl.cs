using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerControl : MonoBehaviour {
	public GameObject spawn1;
	public GameObject spawn2;
	public int counter = 0;

	// Use this for initialization
	void Start () {
		spawn1.gameObject.SetActive (true);
		spawn2.gameObject.SetActive (true);
	}
	
	// Update is called once per frame
	void Update () {
		if (counter >= 10) {
			spawn1.gameObject.SetActive (false);
			spawn2.gameObject.SetActive (false);
		}
		else {
			if (spawn1.gameObject.active && spawn2.gameObject.active) {
				spawn1.gameObject.SetActive(true);
				spawn2.gameObject.SetActive(true);
			}
		}
	}
}
