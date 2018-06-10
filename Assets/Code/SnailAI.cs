using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SnailAI : MonoBehaviour {
	
	public float speed;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (new Vector2 (-speed, 0) * Time.deltaTime);


	}

	void OnTriggerEnter2D(Collider2D stop) {

		if (stop.tag == "opposite") {

			speed *= -1;
		}

		if (stop.tag == "Player") {

			//RELOAD THE SCENE AND DECREASE LIFE COUNTER
			//LifeCounter.Life_Count -=1 ;
			//SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);

			//LOAD GAME OVER IF PLAYER MAKES COLLISION
			SceneManager.LoadScene ("GameOver");

		}



		//RESPAWNING
		//transform.position = new Vector2 (-2.46, -1.14);
		//col.transform.position = respawnPoint.position;


	}
}
