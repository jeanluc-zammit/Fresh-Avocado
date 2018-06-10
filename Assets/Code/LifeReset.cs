using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LifeReset : MonoBehaviour {

	Text Life_Counter;
	public static float Life_Count; //set value here to prevent resetting



	// Use this for initialization
	void Start () {
		Life_Counter = GetComponent<Text> ();

		Life_Count = 3; //This was causing the value to go back to 0 on scene reload
	}

	// Update is called once per frame
	void Update () {

		Life_Counter.text = Life_Count.ToString();

		}

	}



