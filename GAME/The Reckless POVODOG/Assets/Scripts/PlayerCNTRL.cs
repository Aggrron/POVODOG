using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCNTRL : MonoBehaviour {
	private Rigidbody2D rb;

	public float speed = 5f;
	public float jumpForce;
	private bool faceRight = true;
	void Start ()
	{
		rb = GetComponent<Rigidbody2D> ();	
	}
	void Update () {
		
	}
	void FixedUpdate(){
		JumpChanging ();
		float move =  Input.GetAxis("Horizontal");
		rb.velocity = new Vector2(move * speed * Time.deltaTime, rb.velocity.y);
		if (Input.GetKeyDown (KeyCode.Space)) {
			rb.velocity = new Vector2 (rb.velocity.x, jumpForce);

		}
	}
	void JumpChanging()
	{
		if (Input.GetKeyDown (KeyCode.Z)) 
		{
			jumpForce = jumpForce - 1f;
		}
		if (Input.GetKeyDown (KeyCode.X)) 
		{
			jumpForce = jumpForce + 1f;
		}
	
	}
}
