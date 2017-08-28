using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCNTRL : MonoBehaviour {
	private Rigidbody2D rb;

	public float speed = 5f;
	public float jumpForce;
	private bool faceRight = true;
	private Animator anim;
	void Start ()
	{
		rb = GetComponent<Rigidbody2D> ();	
		anim = GetComponent <Animator> ();
	}
	void Update () {
		
	}
	void FixedUpdate(){
		
		float move =  Input.GetAxis("Horizontal");
		rb.velocity = new Vector2(move * speed * Time.deltaTime, rb.velocity.y);
		if (Input.GetKeyDown (KeyCode.Space)) {
			rb.velocity = new Vector2 (rb.velocity.x, jumpForce);
		}
		if (move > 0 && !faceRight)
			flip ();
		else if (move < 0 && faceRight)
			flip ();
		anim.SetFloat ("Speed", Mathf.Abs (move));
	}
	void flip()
	{
		faceRight = !faceRight;
		transform.localScale = new Vector2 (transform.localScale.x * -1, transform.localScale.y);

	}

}
