using UnityEngine;
using UnityEngine.UI;
public class Generate : MonoBehaviour
{

    public GameObject rocks;
    int score = 0;
	public static int c1=0;


    // Use this for initialization
    void Start()
    {
        InvokeRepeating("createObstacles", 12f, 12f);
    }


   void onGUI()
   {
      GUI.color = Color.black;
      GUILayout.Label(" Score: " + score.ToString());

    }
    void createObstacles()
    {
		if (c1 == 0) {
			c1++;
		}
        Instantiate(rocks);


    }

    // Update is called once per frame
    void Update()
    {

    }
}


