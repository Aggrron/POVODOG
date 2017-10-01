using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCNTRL : MonoBehaviour {
	private Rigidbody2D rb;

	public float speed = 5f;
	public float jumpForce;
	private bool faceRight = true;
	private Animator anim;
	public bool isGrounded;
	Transform grounded;
	public LayerMask layerMask;

	void Start ()
	{
		rb = GetComponent<Rigidbody2D> ();	
		anim = GetComponent <Animator> ();
		grounded = GameObject.Find(this.name + "/grounded").transform;
	}
	void Update () {
		
	}
	void FixedUpdate(){

		isGrounded = Physics2D.Linecast (transform.position, grounded.position, layerMask);
		float move =  Input.GetAxis("Horizontal");
		rb.velocity = new Vector2(move * speed * Time.deltaTime, rb.velocity.y);
		if (Input.GetKeyDown (KeyCode.Space)&&isGrounded) {
			Jump ();
			anim.Play ("Jump", -1, 0f);
		
		}
	
		if (move > 0 && !faceRight)
			flip ();
		else if (move < 0 && faceRight)
			flip ();
		anim.SetFloat ("Speed", Mathf.Abs (move));
		anim.SetBool ("OnlyUp", isGrounded);

		if (Input.GetKeyDown (KeyCode.Mouse0))  // Анимация атаки
			anim.Play ("Attack", -1, 0f);
	}
	void flip()// Поворот
	{
		faceRight = !faceRight;
		transform.localScale = new Vector2 (transform.localScale.x * -1, transform.localScale.y);
	}
	void Jump()//Прыжок
	{
		rb.velocity = new Vector2 (rb.velocity.x, jumpForce);
	}
		
		


	}
	
	
	
	



