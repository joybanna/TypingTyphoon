using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour {

    public static bool isTypingCorrect;
    public static bool isTypingWrong;
    public static bool isWordCorrect;
    public static bool isTimeOuttoTyping;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (isTimeOuttoTyping) { isTimeOuttoTyping = false; }
        if (isWordCorrect) { isWordCorrect = false; }
        if (isTypingCorrect) { isTypingCorrect = false; }
        if (isTypingWrong) { isTypingWrong = false; }
    }
}
