using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ArcadeRule : MonoBehaviour
{

    public InputField playername;
    public Text[] highscoreText;
    public GameObject PanalBoard;
    public static int[] highScoreValues;
    public static string[] highScoreName;

    // Use this for initialization
    void Start()
    {
        PanalBoard.SetActive(false);
        highScoreValues = new int[highscoreText.Length];
        highScoreName = new string[highscoreText.Length];
        for (int x = 0; x < highscoreText.Length; x++)
        {
            highScoreValues[x] = PlayerPrefs.GetInt("highScoreValues" + x);
            highScoreName[x] = PlayerPrefs.GetString("highScoreName" + x);
        }
        DrawScore();
    }

    // Update is called once per frame
    void Update()
    {
        //print(highScoreName);
        //print(highScoreValues);
    }
    public void EnterName()
    {
        if (playername.text != "")
        {
            CheckForHighScore(Score.Like_point, playername.text);
            playername.text = "";
            //print("savename");
            PanalBoard.SetActive(true);
        }

    }
    public void SaveScore()
    {
        for (int x = 0; x < highscoreText.Length; x++)
        {
            PlayerPrefs.SetInt("highScoreValues" + x, highScoreValues[x]);
            PlayerPrefs.SetString("highScoreName" + x, highScoreName[x]);
        }

    }
    void DrawScore()
    {
        for (int x = 0; x < highscoreText.Length; x++)
        {
            highscoreText[x].text = highScoreValues[x].ToString() + " Point by " + highScoreName[x].ToString();
        }
    }
    public void DeleteKey()
    {
        for(int x = 0; x < highscoreText.Length; x++)
        {
            PlayerPrefs.DeleteKey("highScoreValues" + x);
            PlayerPrefs.DeleteKey("highScoreName" + x);
            print("clear");
        }
        
    }
    public void CheckForHighScore(int _value, string _name)
    {
        for (int x = 0; x < highscoreText.Length; x++)
        {
            if (_value > highScoreValues[x])
            {
                for (int y = highscoreText.Length - 1; y > x; y--)
                {
                    highScoreValues[y] = highScoreValues[y - 1];
                    highScoreName[y] = highScoreName[y - 1];
                }
                highScoreValues[x] = _value;
                highScoreName[x] = _name;

                DrawScore();
                SaveScore();
                break;
            }
        }
    }
    
}