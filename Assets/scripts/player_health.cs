using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player_health : MonoBehaviour {


	
	// Update is called once per frame
	void Update () {
		if (gameObject.transform.position.y < -2) {
			Die ();
		}


		
	}
	void Die(){
		SceneManager.LoadScene("GameOver");

	}
}
