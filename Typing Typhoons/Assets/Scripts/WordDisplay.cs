using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordDisplay : MonoBehaviour {

	public Text text;
    public Text timetext;
    public Image img;
    //public Image imgB;
   
    private float intime;
    private int scoreplus;

	public void SetWord (string word)
	{        
		text.text = word;        
        NPCTransform.isDes = false;
	}
	public void RemoveLetter ()
	{
        SoundManager.isTyping = true;
		text.text = text.text.Remove(0, 1);
        text.color = Color.red;
	}
	public void RemoveWord ()
	{
        ComboSound.isCombo = true;
        NPCTransform.isDes = true;
        ActionTyping.is_TypingCorrect = true;       
        Score.Like_point += TimeCheck();        
		Destroy(gameObject);

	}   
    private int TimeCheck()
    {
        if (intime > 6)
        {
            scoreplus = 10;            
            ComboSound.numCombo++;
        }
        else if (intime >= 0&& intime<=6)
        {
            scoreplus = 5;            
            ComboSound.numCombo = 1;
        }
        else 
        {
            if (GameController.isCutPoint)
            {
                scoreplus = -10;               
                ComboSound.numCombo = 1;
            }          
        }

        return scoreplus;
    }
    public void Update()
	{
        if (NPCTransform.isStop)
        {
            //print(intime +":"+ WordGenerator.timeCD);
            intime = WordGenerator.timeCD -= Time.deltaTime;
            float timetopoint = Mathf.Ceil(intime * 100) / 100;            
            percent(timetopoint);
            timetext.text = timetopoint.ToString();
        }
    }
    public void percent(float timetopoint)
    {
        //print("MAX :" + WordGenerator.Maxtime);
        float newTime = intime / WordGenerator.Maxtime;
        //print(newTime);
        img.fillAmount = newTime;                
    }

}
