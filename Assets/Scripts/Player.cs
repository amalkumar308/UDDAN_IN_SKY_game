using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public Vector2 jumpForce = new Vector2(0, 300);
    public Vector2 jumpForce1 = new Vector2(300, 0);
    Rigidbody2D myPlayer;
    //public AudioSource song;
    int a = 0;

    // Use this for initialization
    void Start()
    {

        myPlayer = GetComponent<Rigidbody2D>();
     // song.Play();
    }
	//var particle : GameObject;
    // Update is called once per frame
    void Update()
    {

		//for(var touch : Touch in Input.touches)
		//{

			if(Input.touchCount>0 && Input.GetTouch(0).phase==TouchPhase.Ended)
			{

				//var ray = Camera.Main.ScreenPointToRay (Touch.position);
				//if(Physics.Raycast (Ray))
				//{
					myPlayer.velocity = Vector2.zero;
					myPlayer.AddForce(jumpForce);
				//}
			}
		//}








        if (Input.GetKeyUp("up"))
        {
            //for mobile Input.touchCount>0 && Input.GetTouch(0).phase==TouchPhase.Ended;
            myPlayer.velocity = Vector2.zero;
            myPlayer.AddForce(jumpForce);
        }
        else if (Input.GetKeyUp("space"))
        {
            //for mobile Input.touchCount>0 && Input.GetTouch(0).phase==TouchPhase.Ended;
            myPlayer.velocity = Vector2.zero;
            myPlayer.AddForce(jumpForce);
        }
        else if (Input.GetKeyUp("space"))
        {
            //for mobile Input.touchCount>0 && Input.GetTouch(0).phase==TouchPhase.Ended;
            myPlayer.velocity = Vector2.zero;
            myPlayer.AddForce(jumpForce);
        }
        //Die by being OffMeshLink screen
        Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
         if (screenPosition.y > Screen.height || screenPosition.y < 0)
         {
            Die();
         }
         



    }

  void OnCollisionEnter2D(Collision2D other)
   {
   
      Die();

  }
   void Die()
   {
		if (MainMenu.hs< Score.s1)
			MainMenu.hs = Score.s1;
		
		MainMenu.cs = Score.s1;
        Score.s1 = 0;
		Score.s2= 0;
		Score.s3= 0;
         UnityEngine.Application.LoadLevel("menu");
        
        //SceneManager.LoadScene(SceneManager.sceneCount + 1);
       // SceneManager.LoadScene(SceneManager.GetActiceScene().buildIndex + 1);
		if (Score.l1 == 1) 
		{
			Score.l1 = 0;
			UnityEngine.SceneManagement.SceneManager.LoadScene (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().buildIndex - 1);
		}
		if(Score.l2 == 1) 
		{
			Score.l2 = 0;
			//UnityEngine.SceneManagement.SceneManager.LoadScene (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().buildIndex - 1);
			UnityEngine.Application.LoadLevel(Application.loadedLevel);
		}
    }
}
