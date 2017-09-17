using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	private Rigidbody2D rb;
	Renderer myRend;
	public float esm; // Enemy Speed Movement
	public float eld; // Enemy Look Distance
	public float targetDistance; // Our player distance
	public Transform fpsTarget;

	void Start()
	{
		eld = 10f;
		myRend = GetComponent<Renderer> ();
		rb = GetComponent<Rigidbody2D> ();
	}
	void FixedUpdate()
	{
		targetDistance = Vector2.Distance (fpsTarget.position, transform.position);
		if (targetDistance < eld) 
		{
			rb.velocity = new Vector2()
		}
	}
}
