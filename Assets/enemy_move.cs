using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_move : MonoBehaviour {

	public int enemySpeed;
	public int XMoveDirection;


	// Update is called once per frame
	void Update () {

		RaycastHit2D hit = Physics2D.Raycast (transform.position, new Vector2 (XMoveDirection, 0));
		gameObject.GetComponent<Rigidbody2D> ().velocity = new Vector2 (XMoveDirection, 0) * enemySpeed;
		if (hit.distance < 0.7f) {
			Flip ();
		}

	}
	void Flip(){
		if (XMoveDirection > 0) {
			XMoveDirection = -1;
		} else {
			XMoveDirection = 1;
		}
	}
}
