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

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Enemy")
        {
            coll.gameObject.GetComponent<EnemyScript>().hp--;
        }
        Destroy(gameObject);
    }
}
