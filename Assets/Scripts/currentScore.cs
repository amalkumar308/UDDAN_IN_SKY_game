using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class currentScore : MonoBehaviour {

	Text score;
	// Update is called once per frame
	void Start () {
		score = GetComponent<Text> ();

	}

	void Update ()
	{
		score.text = "YOUR AmalScore:" + MainMenu.cs / 20;
	}

}

