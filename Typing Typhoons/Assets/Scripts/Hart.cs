using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hart : MonoBehaviour {
    public Image hartImg;
    private static float maxScore;
    // Use this for initialization
    void Start () {
       

	}
	
	// Update is called once per frame
	void Update ()
    {
        int ScoreM = GameController.scoretoPass;
        maxScore = (float)ScoreM;
        float percentage =Mathf.Ceil((Score.Like_point / maxScore)*100)/100;
        //print(maxScore);
        //print(Score.Like_point);
        SlideFill(percentage);
    }

    private void SlideFill(float percentage)
    {
        hartImg.fillAmount = percentage;
    }
}
