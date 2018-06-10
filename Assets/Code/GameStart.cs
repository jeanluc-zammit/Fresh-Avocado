using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour {
	public int Life_Count; //set value here to prevent resetting


	void Start() {

	}

	void Update () {
		if (Input.GetKey (KeyCode.Return)) {

			SceneManager.LoadScene ("Level 1");

			PlayerPrefs.SetInt("LifeCountStart", Life_Count);

			//Life_Count = 3; //This was causing the value to go back to 0 on scene reload

		}
	}
}
