using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelCard : MonoBehaviour {
	public static int Life_Count; //set value here to prevent resetting

	void Awake() {
		Life_Count = PlayerPrefs.GetInt ("LifeCountStart");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Space)) {

			SceneManager.LoadScene ("Level 1");

		}
	}


}
