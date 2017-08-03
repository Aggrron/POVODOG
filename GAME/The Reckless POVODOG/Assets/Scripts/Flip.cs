using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flip : MonoBehaviour {

	private bool faceRight = true;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (move > 0 && !faceRight)
			flip ();
		
	}
}
