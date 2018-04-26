using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class Gotolevel : MonoBehaviour {

	public void level1()
	{

		SceneManager.LoadScene("LEVEL1");

	}

	public void level2()
	{

		SceneManager.LoadScene("LEVEL2");

	}

	public void level3()
	{

		SceneManager.LoadScene("LEVEL2_1");

	}
}
