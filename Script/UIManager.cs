using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour {



    public void OnCLickRestartButton()
    {
        SceneManager.LoadScene(1);
    }

    public void Jump()
    {
        Player.instance.Jump();
    }

    // Use this for initialization
    void Start () {

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PlayBtn()
    {
        SceneManager.LoadScene(1);
    }
 
}
