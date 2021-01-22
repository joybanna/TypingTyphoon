using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrawLeader : MonoBehaviour {    
    public Text[] highscoreText;

    // Use this for initialization
    void Start () {
        
        for (int x = 0; x < highscoreText.Length; x++)
        {
            //highscoreText[x].text = ArcadeRule.highScoreValues[x].ToString() + " Point by " + ArcadeRule.highScoreName[x].ToString();
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
   
}
