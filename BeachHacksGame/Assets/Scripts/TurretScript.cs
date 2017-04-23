using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretScript : MonoBehaviour {
    public Transform fire;
    public GameObject bullet;

    private int timer;
    [SerializeField]
    private int fireRate;
    // Use this for initialization
    void Start () {
        timer = 0;
        fireRate = 5;
    }
	
	// Update is called once per frame
	void Update () {
        timer += 1;
       
        if (timer * Time.deltaTime > fireRate)
        {
            Instantiate(bullet, fire.position, fire.rotation);
            timer = 0;
        }
    }
}
