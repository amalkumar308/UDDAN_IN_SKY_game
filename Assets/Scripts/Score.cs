using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour {

    public static int scoreValue = 0;
    private float startTime;
    Text score;
    public static int s1,s2,s3;
	public static int l1=0,l2=0,l3=0,l4=0,ls=0;
	// Use this for initialization
	void Start () {
        score = GetComponent<Text>();
        startTime = Time.time;
    }
	
	// Update is called once per frame
	void Update () {
        s1++;
		s2++;
		s3++;
        score.text = "AmalScore:" + (s1/20); //(Time.time - startTime).ToString("0.0");
        if (s1%2000 == 0)
        {
			l1++;
			l2 = 0;
			l3 = 0;
			l4 = 0;
           UnityEngine.Application.LoadLevel(Application.loadedLevel + 1);

        }
		else if(s2%3100 == 0 || (s2%1100 == 0 && Generate.c1!=1))
		{
			l2++;
			l1 = 0;
			l3 = 0;
			l4 = 0;

			UnityEngine.Application.LoadLevel(Application.loadedLevel + 1);

		}
		else if(s3%6000 == 0 || (s3%4000 == 0 && Generate.c1!=1) )
		{
			l2++;
			l1 = 0;
			l3 = 0;
			l4 = 0;

			UnityEngine.Application.LoadLevel(Application.loadedLevel - 2);

		}

	}
}
