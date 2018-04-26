using UnityEngine;
using UnityEngine.UI;
public class Genl2 : MonoBehaviour
{

    public GameObject rocks;
    int score = 0;



    // Use this for initialization
    void Start()
    {
        InvokeRepeating("createObstacles", 26f, 26f);
    }


    void onGUI()
    {
        GUI.color = Color.black;
        GUILayout.Label(" Score: " + score.ToString());

    }
    void createObstacles()
    {
        Instantiate(rocks);


    }

    // Update is called once per frame
    void Update()
    {

    }
}


