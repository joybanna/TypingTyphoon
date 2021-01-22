using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TextTOPic : MonoBehaviour
{
    //private Image imgSourec;
    public SpriteRenderer rendersprite;
    
    // Use this for initialization
    void Start ()
    {
        //imgSourec = GetComponent<Image>();
        rendersprite = GetComponent<SpriteRenderer>();
	}	
	// Update is called once per frame
	void Update ()
    {
       //imgSourec.sprite = PicFormWord();
       rendersprite.sprite = PicFormWord();
    }
   
    public Sprite PicFormWord()
    {
        string name =WordGenerator.randomword;
        Sprite spritelook;
       
        if (name == null)
        {
            //loadingpic
            spritelook= Resources.Load<Sprite>("Pic/loadingSprite") as Sprite;
            return spritelook;
        }
        else
        {
            spritelook=Resources.Load<Sprite>("Pic/" + name) as Sprite;
            return spritelook;
        }        
    }
    
}
