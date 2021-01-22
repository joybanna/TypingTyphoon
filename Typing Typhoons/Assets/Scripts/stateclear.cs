using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stateclear : MonoBehaviour {
    public GameObject stateclearUI;
    public static bool isStateClear;
    // Use this for initialization
    void Start () {
        isStateClear = false;
        stateclearUI.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        if (isStateClear)
        {            
            stateclearUI.SetActive(true);
            PauseGame.isPause = false;
            
        }
        else
        {            
            stateclearUI.SetActive(false);
        }
    }
}
