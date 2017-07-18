using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChase : MonoBehaviour {

	public GameObject player;

	void FixedUpdate(){
		transform.position = new Vector3 (player.transform.position.x, player.transform.position.y, -10f);
	}

}