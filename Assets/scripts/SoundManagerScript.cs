using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour {

	public static AudioClip sfx_jump;
	static AudioSource audioscr;

	// Use this for initialization
	void Start () {

		sfx_jump = Resources.Load<AudioClip> ("sfx_jump");
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public static void PlaySound(string clip){
		switch (clip) {
		case "sfx_jump":
			audioscr.PlayOneShot (sfx_jump);
			break;
		}
	}
}
