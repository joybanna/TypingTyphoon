using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timestop : MonoBehaviour {
    public static bool isTimeStop;
	// Use this for initialization
	void Start () {
        isTimeStop = false;
	}
	
	// Update is called once per frame
	void FixUpdate () {
        if (isTimeStop)
        {
            Time.timeScale = 0f;
            print("ispause");
        }       
	}
}
