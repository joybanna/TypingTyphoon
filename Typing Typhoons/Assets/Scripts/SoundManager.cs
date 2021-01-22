using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {
    
    public AudioClip correctSound;
    public AudioClip wrongSound;
    public AudioClip typingSound;
    public AudioClip stopSound;

    static public bool isCorrect;
    static public bool isWrong;
    static public bool isTyping;
    static public bool isStopMove;

    private AudioSource Source;
	// Use this for initialization
	void Start () {
        Source = GetComponent<AudioSource>();
        isCorrect = false;
        isWrong = false;
        isStopMove = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (isCorrect)
        {
            Source.PlayOneShot(correctSound);
            isCorrect = false;
        }
        else if (isWrong)
        {
            Source.PlayOneShot(wrongSound);
            isWrong = false;
        }
        else if(isTyping)
        {
            Source.PlayOneShot(typingSound);
            isTyping = false;
        }
        else if (isStopMove)
        {
            Source.PlayOneShot(stopSound);
            isStopMove = false;
        }
	}
}
