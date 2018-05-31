using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CollectBattery : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D col) {

		BatteryCounter.Battery_Count += 1;
		Destroy (gameObject);
	}
	

	}

