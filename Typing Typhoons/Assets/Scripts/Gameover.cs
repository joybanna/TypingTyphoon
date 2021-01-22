using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameover : MonoBehaviour {
    public GameObject gameoverUI;
    public static bool isGAmeOver;

	// Use this for initialization
	void Start () {
        isGAmeOver = false;
        gameoverUI.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        if (isGAmeOver)
        {
            Time.timeScale = 0f;
            gameoverUI.SetActive(true);
            PauseGame.isPause = false;
        }
        else 
        {
            //Time.timeScale = 1f;
            //timestop.isTimeStop = false;
            gameoverUI.SetActive(false);
        }
	}
}
