using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class player_score : MonoBehaviour {

	public float timeLeft = 20;
	public int playerScore = 0;
	public GameObject timeLeftUI;
	public GameObject playerScoreUI; 



	
	// Update is called once per frame
	void Update () {
		Debug.Log (timeLeft);
		timeLeft -= Time.deltaTime;
		timeLeftUI.gameObject.GetComponent<Text> ().text = ("Time Left: " + (int)timeLeft);
		playerScoreUI.gameObject.GetComponent<Text> ().text = ("Score: " + playerScore);
		if (timeLeft < 0.1f) {
			SceneManager.LoadScene("basic3");
		}	
	}
	void OnTriggerEnter2D (Collider2D trig){
		if (trig.gameObject.name == "endLevel") {
			CountScore ();
		}
		if (trig.gameObject.name == "coin") {
			playerScore += 10;
		}
	}
	void CountScore () {
		playerScore = playerScore + (int)(timeLeft * 10);
		Debug.Log (playerScore);
	}
}
