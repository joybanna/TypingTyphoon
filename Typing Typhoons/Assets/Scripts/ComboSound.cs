using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComboSound : MonoBehaviour {
    static public bool isCombo;
    public AudioClip com1;
    public AudioClip com2;
    public AudioClip com3;
    public AudioClip com4;
    public AudioClip com5;
    public AudioClip com6;
    public AudioClip com7;

    private AudioSource Source;
    static public int numCombo;

	// Use this for initialization
	void Start () {
        Source = GetComponent<AudioSource>();
        isCombo = false;
        numCombo = 1;
	}
	
	// Update is called once per frame
	void Update ()
    {
        
        if (isCombo)
        {
            if (numCombo > 7)
            {
                Source.PlayOneShot(com6);
                Score.Like_point += 15;
            }
            switch (numCombo)
            {
                case 1:
                    Source.PlayOneShot(com1);
                    break;
                case 2:
                    Source.PlayOneShot(com2);
                    Score.Like_point += 2;
                    break;
                case 3:
                    Source.PlayOneShot(com3);
                    Score.Like_point += 4;
                    break;
                case 4:
                    Source.PlayOneShot(com4);
                    Score.Like_point += 6;
                    break;
                case 5:
                    Source.PlayOneShot(com5);
                    Score.Like_point += 8;
                    break;
                case 6:
                    Source.PlayOneShot(com6);
                    Score.Like_point += 10;
                    break;
                case 7:
                    Source.PlayOneShot(com7);
                    Score.Like_point += 15;
                    break;
            }
            isCombo = false;
        }   
		

	}
}
