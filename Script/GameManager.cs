using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public static GameManager instance;
    public GameObject player;
    public Transform StartPos;
    private bool spawnNewPlayer;
    public Text WinText;
    public Text Life;
    public Text Point;
    //public int life;
    public int pointspeed;
    public int CountPoint = 0;
    public Button Restart;

    // Use this for initialization
    void Start () {

        Restart.gameObject.SetActive(false);

        Newplayer();

        //life = 100;

        instance = this;
		
	}
	
	// Update is called once per frame
	void Update () {

        SetCount();

        if (spawnNewPlayer)
        {
            Newplayer();
        }

    
		
	}

    void Newplayer ()
    {
        spawnNewPlayer = false;
        Instantiate(player, StartPos.position, Quaternion.identity);
    }

    void SetCount()
    {
       // Life.text = "Life : " + life.ToString();
        Point.text = " " + CountPoint.ToString();
        /*if (life==0)
        {
            WinText.text = "Game Over" ;

            Player.instance.JumpSpeed = 0;
            Rotate.instance.speed = 0;
            Restart.gameObject.SetActive(true);
        }
        */
      
        if (pointspeed ==10)
        {
            Rotate.instance.speed += 1;

            pointspeed = 0;

        }


    }
    public void GameOver()

    {
        WinText.text = "Game Over";

        Player.instance.JumpSpeed = 0;
        Rotate.instance.speed = 0;
        Restart.gameObject.SetActive(true);

    }

}
