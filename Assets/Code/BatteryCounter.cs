using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BatteryCounter : MonoBehaviour {

	Text Battery_Counter;
	public static int Battery_Count;

	public Text Level_Complete;
	public GameObject LevelComplete;

	// Use this for initialization
	void Start () {
		Battery_Counter = GetComponent<Text> ();
		Battery_Count = 0; //This was causing the value to go back to 0 on scene reload

		LevelComplete.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {

		Battery_Counter.text = Battery_Count.ToString();

		if (Battery_Count >= 10) {

			LevelComplete.SetActive (true);

			Time.timeScale = 0;

			if (Input.GetKey (KeyCode.Space)) {

				Time.timeScale = 1;

				SceneManager.LoadScene ("End Screen");
			}

		}
	}
}
