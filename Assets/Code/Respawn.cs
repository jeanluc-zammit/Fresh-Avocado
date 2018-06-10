using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour {

	//RESPAWNING

	//[SerializeField] private Transform player;
	 Transform respawnPoint;

	void OnCollisionEnter2D(Collision2D other) 
	{

		if (other.transform.CompareTag ("Player")) 
		{

			//transform.position = new Vector2 (-2.46, -1.14);
			//other.transform.position = respawnPoint.position;
			//SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
			SceneManager.LoadScene ("GameOver");
			//LifeCounter.Life_Count --;
		}
	}
}
