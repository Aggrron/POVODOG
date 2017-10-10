using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {


	public float esm; // Enemy Speed Movement
	public float eld; // Enemy Look Distance
	public float targetDistance; // Our player distance
	public Transform fpsTarget;//
	private bool faceRight = true;
	private Animator anim;



	void Start()
	{
		eld = 10f;
		anim = GetComponent<Animator> ();
	}
	void Update()
	{
		anim.SetFloat ("MonsterSpeed", esm);
	}
	void FixedUpdate()
	{
		
		targetDistance = Vector2.Distance (fpsTarget.position, transform.position);
		if (targetDistance < eld) {
			esm = 5f;
			transform.position = Vector2.MoveTowards (transform.position, fpsTarget.position, Time.deltaTime * esm);
		} else
			esm = 0f;
		if (transform.position.x < fpsTarget.transform.position.x && faceRight)
			flip ();
		else if (transform.position.x > fpsTarget.transform.position.x && !faceRight)
			flip ();
//		if (targetDistance < eld / 2) 
//		{
//			anim.Play ("BigMouth_Attack");
//		}




	}
	void flip()
	{
		faceRight = !faceRight;
		transform.localScale = new Vector3 (transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);

	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Attack") 
		{
			Debug.Log ("UDAR");
		}

	}
}
