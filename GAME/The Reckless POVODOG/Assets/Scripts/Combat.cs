using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Combat : MonoBehaviour {

	private Rigidbody2D rb;
	public GameObject[] attack;
	private Vector2 coord;


	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}


	void FixedUpdate() {
		coord = new Vector2 (rb.transform.position.x -0.04f, rb.transform.position.y + 0.03f);
		if (Input.GetKeyDown (KeyCode.Mouse0)) {
			Instantiate (attack [0],coord, Quaternion.identity);

		}
		}

}
