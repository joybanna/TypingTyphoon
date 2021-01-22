using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionTyping : MonoBehaviour
{

    static public bool is_TypingCorrect;
    static public bool is_TypingWrong;
    static public bool is_Typing;

    // Use this for initialization
    void Start () {
        is_TypingCorrect = false;
        is_TypingWrong = false;
        is_Typing = false;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (is_TypingCorrect)
        {
            ActionWaiter.is_Correct = true;
            is_TypingCorrect = false;
        }
        else if (is_TypingWrong)
        {
            ActionWaiter.is_Wrong = true;
            ComboSound.numCombo = 1;
            is_TypingWrong = false;
        }
        else if (is_Typing)
        {

            is_Typing = false;
        }
	}
}
