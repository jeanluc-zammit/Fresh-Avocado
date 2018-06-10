using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BeeAI : MonoBehaviour {

	public float speed;

	//public float stoppingDistance;

	//private Transform target;
	/*
	int direction = 1; //int direction where 0 is stay, 1 up, -1 down    
	int top = 2;
	int bottom = -2;
	*/

	[SerializeField] Transform respawnPoint;

	// Use this for initialization
	void Start () {

		//target = GameObject.FindGameObjectWithTag ("Player").GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		//CHASE PLAYER
		/*
		if (Vector2.Distance (transform.position, target.position) > stoppingDistance) {
			transform.position = Vector2.MoveTowards (transform.position, target.position, speed * Time.deltaTime);
		}
		*/

		transform.Translate (new Vector2 (0, -speed) * Time.deltaTime);
		/*
		if (transform.position.y >= top)
			direction = -1;

		if (transform.position.y <= bottom)
			direction = 1;

		transform.Translate(0, speed * direction * Time.deltaTime, 0);
	}
	*/

}

	void OnTriggerEnter2D(Collider2D col) {

		if (col.tag == "opposite") {

			speed *= -1;
		}

		if (col.tag == "Player") {

			//RELOAD THE SCENE AND DECREASE LIFE COUNTER
			//LifeCounter.Life_Count -=1 ;
			//SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);

			//LOAD GAME OVER IF PLAYER MAKES COLLISION
			SceneManager.LoadScene ("GameOver");

		}

		//transform.position = new Vector2 (-2.46, -1.14);
		//col.transform.position = respawnPoint.position;

		//LifeCounter.Life_Count -= 1;
		//Destroy (gameObject);
		//SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex - 1);
	}
}
