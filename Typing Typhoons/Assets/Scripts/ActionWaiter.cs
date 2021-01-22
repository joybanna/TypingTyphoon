using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionWaiter : MonoBehaviour {
    static public bool is_Correct;
    static public bool is_Wrong;
    private Animator anim;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        is_Correct = false;
        is_Wrong = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (is_Correct)
        {
            anim.SetTrigger("isCorrect");
            SoundManager.isCorrect = true;
            is_Correct = false;
        }
        else if (is_Wrong)
        {
            anim.SetTrigger("isWrong");
            SoundManager.isWrong = true;
            is_Wrong = false;
        }
        else
        {

        }
	}
}
