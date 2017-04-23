using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	public int speed;               //Speed of the player
    public int hp;                  //hp of the player
    //Animator animatorObj;

    [SerializeField]
    private Transform[] groundPoints;       

    [SerializeField]
    private float groundRadius;

    [SerializeField]
    private LayerMask whatIsGround;
    private bool isGrounded, _jump;

    [SerializeField]
    private float jumpForce;                //The jump force of the player

    public bool hasTurret, hasWire;         //Check to see if the player has turrets or wires

    // Use this for initialization
    void Start () {
        hasTurret = hasWire = false;
        hp = 5; 
	}
	
	// Update is called once per frame
	void Update () 
	{ // directional buttons
		if (Input.GetKey(KeyCode.W)) 
		{
			Debug.Log ("up");                   //Move up

		}
		if (Input.GetKey(KeyCode.A)) 
		{
			Debug.Log ("left");
			transform.Translate (-speed*Time.deltaTime, 0, 0);          //Move left
		
		}
		if (Input.GetKey(KeyCode.S)) 
		{
			Debug.Log("down");                  //Move down


		}
		if (Input.GetKey(KeyCode.D)) 
		{
			Debug.Log ("right");
			transform.Translate (speed*Time.deltaTime, 0, 0);           //Move right

		}

        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce));     //Jump
        }
        if(hp == 0)
        {
            Time.timeScale = 0;         //Stops game when player hp = 0
        }

    }

    private bool IsGrounded()
    {
        if (gameObject.GetComponent<Rigidbody2D>().velocity.y <= 0)
        {
            foreach (Transform point in groundPoints)
            {
                Collider2D[] colliders = Physics2D.OverlapCircleAll(point.position, groundRadius, whatIsGround);

                for (int i = 0; i < colliders.Length; i++)
                {
                    if (colliders[i].gameObject != gameObject)
                    {
                        return true;
                    }
                }
            }
        }

        return false;
    }
}