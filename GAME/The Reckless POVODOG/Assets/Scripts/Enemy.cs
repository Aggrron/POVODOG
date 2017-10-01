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
	private Animator anim;
	public float health;


	void Start()
	{
		eld = 10f;
		health = 10f;
		myRend = GetComponent<Renderer> ();
		rb = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();
	}
	void FixedUpdate()
	{
		esm = 0f;
		targetDistance = Vector2.Distance (fpsTarget.position, transform.position);
		if (targetDistance < eld) {
			esm = 6f;
			transform.position = Vector2.MoveTowards (transform.position, fpsTarget.position, Time.deltaTime * esm);
		} else
			esm = 0f;
		if (transform.position.x < fpsTarget.transform.position.x && faceRight)
			flip ();
		else if (transform.position.x > fpsTarget.transform.position.x && !faceRight)
			flip ();
		if (targetDistance < eld / 2) 
		{
			anim.Play ("BigMouth_Attack");
		}



		anim.SetFloat ("MonsterSpeed", esm);
	}
	void flip()
	{
		faceRight = !faceRight;
		transform.localScale = new Vector3 (transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);

	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Attack") 
		{
			health = health - 5f;
			Debug.Log ("UDAR");
		}

	}
}
