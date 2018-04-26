using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
	public static int hs=0;
	public static int cs=0;

	public void PlayGame()
	{
		
		SceneManager.LoadScene("LEVEL1");


	}


	public void QuitGame()
	{
		Debug.Log ("Quit");
		Application.Quit ();

	}
}
