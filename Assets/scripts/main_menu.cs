using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class main_menu : MonoBehaviour {

	public void PlayGame (){

		SceneManager.LoadScene ("basic3");

	}

	public void QuitGame(){

		Application.Quit ();
	}

	public void OpenMenu (){

		SceneManager.LoadScene("Menu");
	}

	public void OpenRules(){

		SceneManager.LoadScene ("Rules");
	}
}
