using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	public int speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{ // directional buttons
		if (Input.GetKey(KeyCode.W)) 
		{
			Debug.Log ("up");

		}
		if (Input.GetKey(KeyCode.A)) 
		{
			Debug.Log ("left");
			transform.Translate (-speed*Time.deltaTime, 0, 0);
		
		}
		if (Input.GetKey(KeyCode.S)) 
		{
			Debug.Log("down");


		}
		if (Input.GetKey(KeyCode.D)) 
		{
			Debug.Log ("right");
			transform.Translate (speed*Time.deltaTime, 0, 0);

		}

	}
}