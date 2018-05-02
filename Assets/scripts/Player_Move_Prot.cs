using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move_Prot : MonoBehaviour {

	public int playerSpeed = 10;
	public bool facingRight;
	public int playerJumpPower = 1250;
	public float moveX;
	public bool isGrounded = false;
	public bool isJumping = false;
	private Animator myAnimator;


	void Start(){
		myAnimator = GetComponent<Animator> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		PlayerMove ();
		HandleLayers ();

	}
	void PlayerMove(){
		moveX = Input.GetAxis("Horizontal");

		if (Input.GetButton ("Jump")) {
			Jump ();
			isGrounded = false;
		}

		if (moveX < 0.0f && facingRight == false) {
			FlipPlayer ();
		} 
		else if (moveX > 0.0f && facingRight == true) {
			FlipPlayer ();
		}

		gameObject.GetComponent<Rigidbody2D> ().velocity = new Vector2 (moveX * playerSpeed, gameObject.GetComponent<Rigidbody2D> ().velocity.y);
		myAnimator.SetFloat ("speed", Mathf.Abs(moveX));
	}
	void Jump (){
		if (isGrounded == true) {
			GetComponent<Rigidbody2D> ().AddForce (Vector2.up * playerJumpPower);
			myAnimator.SetFloat ("jumpspeed", Mathf.Abs(moveX));
			isJumping = true;



		}
	}
	void FlipPlayer (){
		facingRight = !facingRight;
		Vector2 localScale = gameObject.transform.localScale;
		localScale.x *= -1;
		transform.localScale = localScale;
	
	}

	void OnCollisionEnter2D (Collision2D col){
		Debug.Log ("Player has collided with" + col.collider.name);
		if (col.gameObject.tag == "ground"){
			isGrounded = true;
		}
	}
	void OnCollisionExit2D (Collision2D col){
		if (col.gameObject.tag == "ground"){
			isGrounded = false;
		}
	}

	private void HandleLayers(){
		if (!isGrounded) {
			myAnimator.SetLayerWeight (1, 1);
		} else {
			myAnimator.SetLayerWeight (1, 0);
		}
	}


}
