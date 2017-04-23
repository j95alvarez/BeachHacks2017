using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingMechanic : MonoBehaviour {
   
   public GameObject projectile;    // Will hold a projectile prefab
   public Vector3 velocity;         // Speed of projectile, X and Y should be the same
   public float speed;
   public Vector3 offset = new Vector3(1.0f, 1.0f);
   private bool canShoot = true;    // Determines if we can shoot
   public float cooldown = 1.0f;    // Time in between every shot made
   
	// Use this for initialization
	void Start () {
		
	}

   private Vector3 unitVector() {
      return new Vector3();
   }
	
	// Update is called once per frame
	void Update () {
      // Clicking will make the player shoot a projectile
		if (Input.GetMouseButtonDown(0) && canShoot) {
         var heading = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
         var distance = heading.magnitude;
         var direction = heading / distance;
         
         GameObject g = (GameObject) Instantiate(projectile, transform.position + offset * transform.localScale.x, Quaternion.identity);
         // Gets the world coordinates of where the mouse cursor currently is

         g.GetComponent<Rigidbody2D>().velocity = new Vector3(speed * direction.x, speed * direction.y);
      }
	}
   
   // Coroutine for the cooldown between shots
   IEnumerator CanShoot() {
      canShoot = false;
      yield return new WaitForSeconds(cooldown);
      canShoot = true;
   }
}

/* Notes
      Input.mousePosition returns screen coordinates
      transform.position returns world coordinates 
      use these to convert from one another
      Camera.WorldToScreenPoint and Camera.ScreenToWorldPoint

      Input.GetMouseButtonDown(0) // Left Click
      Input.GetMouseButtonDown(1) // Right Click
      Input.GetMouseButtonDown(2) // Middle Click
*/