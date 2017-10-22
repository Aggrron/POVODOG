using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spider : MonoBehaviour {
	private bool faceRight = true;
	//---------------------
	private Rigidbody2D rb;
	public Transform player;
	private Animator anim;
	//---------Public Stats---------
	public float eld;
	public float moveSpeed;
	private float targetDistance;


	void Start () {
		//rb = GetComponent<Rigidbody2D> ();
		//anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		//---------------------Поворот-------------
		if (transform.position.x < player.position.x && faceRight)
			flip ();
		if (transform.position.x > player.position.x && !faceRight)
			flip ();
			
	}
	void FixedUpdate()
	{
		targetDistance = Vector2.Distance (player.transform.position, transform.position);

		if (targetDistance < eld) 
		{
			transform.position = Vector2.MoveTowards (transform.position, player.transform.position, moveSpeed * Time.deltaTime);	
		}
	}
	void flip() //Поворот
	{
		faceRight = !faceRight;
		transform.localScale = new Vector3 (transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
	}

}
