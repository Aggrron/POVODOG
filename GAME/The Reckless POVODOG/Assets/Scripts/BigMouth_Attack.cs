using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigMouth_Attack : MonoBehaviour {
	private bool readyNow = true;
	//------------------------------
	public GameObject[] attacks;
	private GameObject attack0;
	public Transform Target;
	private Animator anim;
	//------------------
	private float targetDistance;
	private Vector2 coord;
	void Start () {
		anim = GetComponent<Animator> ();
	}
	

	void Update () {
		coord = new Vector2 (transform.position.x - 2.23f, transform.position.y + 1.39f);
		targetDistance = Vector2.Distance (Target.position, transform.position);
		if (targetDistance < 5f) {
			if (readyNow) {	
				StartCoroutine (attack_1());

			}
		} else 
		{
			StopCoroutine (attack_1 ());
		}
	}

	IEnumerator attack_1()// Первая атака уебка  
	{
		readyNow = false;
		anim.Play ("BigMouth_Attack");
		attack0 = Instantiate (attacks [0], coord, Quaternion.identity) as GameObject;
		attack0.transform.parent = transform;
		DestroyObj (attack0);
		yield return new WaitForSeconds (2f);
		readyNow = true;
	}

	void DestroyObj(GameObject obj)
	{
		DestroyObject (obj, 0.3f);
	}
}
