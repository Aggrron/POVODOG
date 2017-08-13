using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladder : MonoBehaviour {

	private Rigidbody2D rb;
	private bool ladder = false;
	public float ladderSpeed;
	void Start()
	{
		rb = GetComponent<Rigidbody2D> ();
	}
	void OnTriggerStay2D(Collider2D obj)
	{
		if (obj.gameObject.tag == "Ladder") 
		{
			ladder = true;
			
		}

	}
	void OnTriggerExit2D(Collider2D obj)
	{
		if (obj.gameObject.tag == "Ladder") 
		{
			ladder = false;

		}
	}
	void FixedUpdate(){
	
		if (ladder) {
			float moveUp = Input.GetAxis ("Vertical") * ladderSpeed;
			moveUp = moveUp * Time.deltaTime;
				rb.velocity = new Vector2 (0, moveUp);
			}
//			float moveUP = Input.GetAxis ("Vertical");
//			rb.velocity = new Vector2 (rb.velocity.x, moveUP * ladderSpeed * Time.deltaTime);
		} 
			
	}


