using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {
    public float speed;

    Rigidbody2D myRigidBody;
    private int timer;
	// Use this for initialization
	void Start () {
        timer = 0;
        myRigidBody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        timer += 1;
        myRigidBody.velocity = new Vector2(speed, myRigidBody.velocity.y);
        if(timer * Time.deltaTime > 5)
        {
            Destroy(gameObject);
        }
        
	}

  
}
