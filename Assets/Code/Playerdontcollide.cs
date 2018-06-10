using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerdontcollide : MonoBehaviour {

	//COLLISION IGNORES
	public GameObject box1;
	public GameObject box2;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Physics2D.IgnoreCollision (box1.GetComponent<Collider2D>(), box2.GetComponent<Collider2D>());
	}
}
