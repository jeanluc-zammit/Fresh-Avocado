using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CollectBattery : MonoBehaviour {

	public Text BatteryCount;

	public int CountBattery;

	// Use this for initialization
	void Start () {
		CountBattery = 0;
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D Player) {

		if (Player.tag == "battery") {

			CountBattery ++;

			Debug.Log (CountBattery);

		}
	}
}
