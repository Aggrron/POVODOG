using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	private Rigidbody2D rb;
	public Transform endPoint;
	public Vector2 position;
	void Start() {
		rb = GetComponent <Rigidbody2D>();
	}
	void FixedUpdate(){
		position = endPoint.localPosition;
	//rb.velocity = new Vector2 (position, 0f);
	
	}

}
