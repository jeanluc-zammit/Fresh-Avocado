using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {

	public float startingTimer;

	//Color c = new Color (0f, 0f, 0f, 0f);

	public Timer overlay;

	private Text theText;

	// Use this for initialization
	void Start () {
		
		theText = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {

		startingTimer -= Time.deltaTime;

		theText.text = "" + Mathf.Round (startingTimer);

		if (startingTimer <= 0) {

			SceneManager.LoadScene ("GameOver");

			//Time.timeScale = 0;

		}

		//overlay.color 

	}
}
