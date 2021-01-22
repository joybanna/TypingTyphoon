using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordManager : MonoBehaviour {

	public List<Word> words;
	public WordSpawner wordSpawner;
	private bool hasActiveWord;
	private Word activeWord;
    
	public void AddWord ()
	{
        
            Word word = new Word(WordGenerator.GetRandomWord(GameController.Easy, GameController.Normal, GameController.Hard), wordSpawner.SpawnWord());
            //Debug.Log(word.word);
            words.Add(word);
       
                        
    }
	public void TypeLetter (char letter)
	{
		if (hasActiveWord)
		{
			if (activeWord.GetNextLetter() == letter)
			{
                //print("V"); correct
                activeWord.TypeLetter();
			}
            else if (activeWord.GetNextLetter() != letter)
            {
                ActionTyping.is_TypingWrong = true;                
                if (GameController.isCutPointWong)
                {
                    Score.Like_point -= 5;
                    print("X");//wrong 
                }
            }
        }
        else
		{          
			foreach(Word word in words)
			{
				if (word.GetNextLetter() == letter)
				{
					activeWord = word;
					hasActiveWord = true;
					word.TypeLetter();                    
					break;
				}
                else if (word.GetNextLetter() != letter)
                {
                    ActionTyping.is_TypingWrong = true;
                    if (GameController.isCutPointWong)
                    {                        
                        Score.Like_point -= 5;
                        //print("X");//wrong 
                    }
                   
                }
               
            }
		}
		if (hasActiveWord && activeWord.WordTyped())
		{
			hasActiveWord = false;
			words.Remove(activeWord);
		}
	}

}
