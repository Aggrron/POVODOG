using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCNTRL : MonoBehaviour {
	
	private Rigidbody2D rb;
	private Animator anim;
	//-------------------------------------------
	public float speed = 5f;
	public float jumpForce;
	private bool faceRight = true;
	public bool isGrounded;
	Transform grounded;
	public LayerMask layerMask;
	//----------------------------
	public GameObject[] attack;//Массив атак


	void Start ()
	{
		rb = GetComponent<Rigidbody2D> ();	
		anim = GetComponent <Animator> ();
		grounded = GameObject.Find(this.name + "/grounded").transform;
	}
	void FixedUpdate(){

		isGrounded = Physics2D.Linecast (transform.position, grounded.position, layerMask);//Касаются ли
		float move =  Input.GetAxis("Horizontal");
		rb.velocity = new Vector2(move * speed * Time.deltaTime, rb.velocity.y);//Движение по горизонтали
		if (Input.GetKeyDown (KeyCode.Space)&&isGrounded) { //Прыжок
			Jump ();
			anim.Play ("Jump", -1, 0f);
		
		}
	
		if (move > 0 && !faceRight)//Перевороты
			flip ();
		else if (move < 0 && faceRight)
			flip ();
		anim.SetFloat ("Speed", Mathf.Abs (move));
		anim.SetBool ("OnlyUp", isGrounded);

		if (Input.GetKeyDown (KeyCode.Mouse0))  // Анимация атаки
			attackFirst();
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
	//-----------------------------------------COMBAT------------------------
	void attackFirst()
	{
		anim.Play ("Attack", -1, 0f);
	}
	}
	
	
	
	



