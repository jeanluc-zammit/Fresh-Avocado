using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

	private Rigidbody2D rb2d;
	//public float offset;
	//public float moveForce = 365f;
	public float maxSpeed = 5f;
	public float jumpForce = 50f;
	//private bool isJumping = false;





	//BATTERY PROPERTIES

	//battery count text
	//public Text BatteryCount;

	//variable for battery
	//public int CountBattery;


	// Use this for initialization
	void Awake () {

		rb2d = this.GetComponent<Rigidbody2D> ();

	}

	void Start()
	{
		/*
		float x = Camera.main.ViewportToWorldPoint (Vector3.zero).x;
		Vector3 pos = transform.position;
		pos.x = x + offset;
		transform.position = pos;
		*/
		//the text which will appear on screen

		//setting battery variable count to 0
		//CountBattery = 0;



	}

	// Update is called once per frame
	void Update ()
	{
		//isTouchingGround = Physics2D.OverlapBox (groundCheck.position, groundCheckRadius, groundLayer);

		if (Input.GetKey (KeyCode.RightArrow)) {
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (maxSpeed, GetComponent<Rigidbody2D> ().velocity.y);
		}
		else if (Input.GetKey (KeyCode.Space)) {
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (GetComponent<Rigidbody2D> ().velocity.x, jumpForce);
			//rb2d.AddForce(Vector2.up * jumpForce * Time.deltaTime);
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (-maxSpeed, GetComponent<Rigidbody2D> ().velocity.y);
		}
		else if (Input.GetKey (KeyCode.Space)) {
		 GetComponent<Rigidbody2D> ().velocity = new Vector2 (GetComponent<Rigidbody2D> ().velocity.x, jumpForce);
			//rb2d.AddForce(Vector2.up * jumpForce * Time.deltaTime);
		}

	}
		
	/*
	void OnCollisionEnter2D(Collision2D col) {
			//Physics2D.IgnoreCollision(opposite, collider2D);
		Physics2D.IgnoreLayerCollision(9, 10);

	}*/




	//}

}


		/*		
		if (Input.GetKey (KeyCode.UpArrow)) {

			rb2d.velocity = new Vector2 (0f, 5f);

		} else if (Input.GetKey (KeyCode.DownArrow)) {

			rb2d.velocity = new Vector2 (0f, -5f);

		} else if (Input.GetKey (KeyCode.LeftArrow)) {

			rb2d.velocity = new Vector2 (-5f, 0f);

		} else if (Input.GetKey (KeyCode.RightArrow)) {

			rb2d.velocity = new Vector2 (5f, 0f);

		} else if (Input.GetKey (KeyCode.Space)) {

			rb2d.AddForce (Vector2.up * jumpForce);

		} else {

			rb2d.velocity = new Vector2(0f, 0f);
		}*/
		


		//BatteryCount.text = CountBattery.ToString();
	







	// if touches the player, add 1 to battery count and destroy instance
	/*
	void OnTriggerEnter2D (Collider2D batt) {

		if (batt.tag == "battery") {

			CountBattery++;

			Debug.Log (CountBattery);

			//Destroy(GameObject.Find("battery"));
			Destroy (GameObject.FindWithTag("battery"));

		}
	}
	*/
