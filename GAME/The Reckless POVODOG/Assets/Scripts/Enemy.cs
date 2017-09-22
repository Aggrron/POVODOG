using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	private Rigidbody2D rb;
	Renderer myRend;
	public float esm; // Enemy Speed Movement
	public float eld; // Enemy Look Distance
	public float targetDistance; // Our player distance
	public Transform fpsTarget;//
	private bool faceRight = true;


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
			transform.position = Vector2.MoveTowards (transform.position, fpsTarget.position, Time.deltaTime * esm);
		}
		if (transform.position.x < fpsTarget.transform.position.x && faceRight)
			flip ();
		else if (transform.position.x > fpsTarget.transform.position.x && !faceRight)
			flip ();
	}
	void flip()
	{
		faceRight = !faceRight;
		transform.localScale = new Vector3 (transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
	}
}
