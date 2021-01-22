using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour {
    public static bool isPause;
    public GameObject panalGamepuuse;
	// Use this for initialization
	void Start () {
        panalGamepuuse.SetActive(false);
        isPause = true;
        //Cursor.visible = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyUp(KeyCode.Escape)&&isPause)
        {
            Time.timeScale = 0f;
            panalGamepuuse.SetActive(true);            
            isPause = false;
            //Cursor.visible = true;
            //print("s");
        }
        else if(Input.GetKeyUp(KeyCode.Escape) && !isPause)
        {
            Time.timeScale = 1f;
            panalGamepuuse.SetActive(false);           
            isPause = true;
            //Cursor.visible = false;
            //print("p");
        }
	}
}
