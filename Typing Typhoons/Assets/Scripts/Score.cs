using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    private Text ScoreText;
    private static int like_point;
    public static int Like_point
    {
        get
        {
            return like_point;
        }

        set
        {
            like_point = value;
        }
    }

    // Use this for initialization
    void Start () {
        ScoreText = GetComponent<Text>();
        Like_point = 0;
	}
	
	// Update is called once per frame
	void Update () {
        ScoreText.text = "Like: "+Like_point.ToString();
        if (Like_point < 0)
        {
            Gameover.isGAmeOver = true;
        }
	}
}
