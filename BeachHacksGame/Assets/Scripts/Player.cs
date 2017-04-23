using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	public int speed;
    public Transform pause;
    public GameObject[] items; 
    //Animator animatorObj;

    [SerializeField]
    private Transform[] groundPoints;

    [SerializeField]
    private float groundRadius;

    [SerializeField]
    private LayerMask whatIsGround;
    private bool isGrounded, _jump;

    [SerializeField]
    private float jumpForce;

    public bool hasTurret, hasWire;

    // Use this for initialization
    void Start () {
        hasTurret = hasWire = false;
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

        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce));
        }

        if (Input.GetKeyDown(KeyCode.E) && hasTurret)
        {
            Instantiate(items[0], transform.position + (new Vector3(1,0,0)), Quaternion.identity);
        }

        if (Input.GetKeyDown(KeyCode.Q) && hasWire)
        {
            Instantiate(items[1], transform.position + (new Vector3(-1,-0.5f,0)), Quaternion.identity);
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