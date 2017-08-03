using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour {

	Vector2 position;
	Vector3 position2;


	void Start () {
		
		position = new Vector2 (2f, 6f);
		Debug.Log ("Position x" + "   " + position.x);
		Debug.Log (position.y);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void FixedUpdate()
	{
		
	}
}
