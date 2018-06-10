using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LifeCounter : MonoBehaviour {

	Text Life_Counter;
	public static float Life_Count = 3; //set value here to prevent resetting



	// Use this for initialization
	void Start () {
		Life_Counter = GetComponent<Text> ();


	}
		

	// Update is called once per frame
	void Update () {

		Life_Counter.text = Life_Count.ToString();

		if (Life_Count <= 0) {

			SceneManager.LoadScene ("GameOver");

			//Time.timeScale = 0;

			}

		}

	}



