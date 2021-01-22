using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timecount : MonoBehaviour {
    public Slider bar;
    private float timemax;
    private float timeCurrent;
    public static float timeingame;
    private float multipletime = 1000f;
	// Use this for initialization
	void Start ()
    {               
       timemax = GameController.Timeout;
       timeCurrent = timemax;
       bar.maxValue = multipletime;
	}	
	// Update is called once per frame
	void Update ()
    {
        timeingame = timeCurrent -= Time.deltaTime;
        float time = Mathf.Ceil(timeingame * 100) / 100;
        bar.value = (time / timemax) * multipletime;
        //print((time / timemax)*multipletime);        
        if (bar.value == 0)
        {
            Gameover.isGAmeOver = true;
        }
	}

}
