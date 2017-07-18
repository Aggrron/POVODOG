﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCNTRL : MonoBehaviour {
	private Rigidbody2D rb;

	public float speed = 5f;
	void Start ()
	{
		rb = GetComponent<Rigidbody2D> ();	
	}
	void Update () {
		
	}
	void FixedUpdate(){
		float move =  Input.GetAxis("Horizontal");
		rb.velocity = new Vector2(move * speed * Time.deltaTime, rb.velocity.y);
	}
}
