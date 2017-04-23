using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour {

    private Canvas pauseCanvas;

	// Use this for initialization
	void Start () {
        pauseCanvas = GameObject.Find("Canvas").GetComponent<Canvas>();
        pauseCanvas.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pauseCanvas.enabled == false)
            {
                pauseCanvas.enabled = true;
                Time.timeScale = 0f;
            }
            else
            {
                pauseCanvas.enabled = false;
                Time.timeScale = 1f;
            }

            /*
            if (Time.timeScale == 0f)

                Time.timeScale = 1f;
            else
            {
                Time.timeScale = 0f;
            }
            */
        }
	}
}
