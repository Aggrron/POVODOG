using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladder : MonoBehaviour {


	public float ladderSpeed = 10f;

	void Start () {
	}
	
	void OnTriggerStay2D(Collider2D other)
	{
		if (other.tag == "Player" && Input.GetKey (KeyCode.W)) {
			other.GetComponent<Rigidbody2D> ().gravityScale = 0f;
			other.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, ladderSpeed);
		} else if (other.tag == "Player" && Input.GetKey (KeyCode.S)) {
			other.GetComponent<Rigidbody2D> ().gravityScale = 0f;
			other.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, -ladderSpeed);
		} else 
		{
			//other.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, 1);
		}
	
	}

}
