﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BatteryCounter : MonoBehaviour {

	Text Battery_Counter;
	public static int Battery_Count;

	// Use this for initialization
	void Start () {
		Battery_Counter = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {

		Battery_Counter.text = Battery_Count.ToString();
	}
}
