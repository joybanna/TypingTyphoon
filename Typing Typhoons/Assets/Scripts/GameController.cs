using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
    #region FixinInspactor
    [Header("MODE")]
    public bool isEasy;
    public bool isNormal;
    public bool isHard;

    [Header("CUTPOINT")]
    [Tooltip("หักคะแนนจากหมดเวลาพิมพ์")]
    public bool cutPointformtimeout;
    [Tooltip("หักคะแนนจากพิมพ์ผิด")]
    public bool cutPointformWrongTyping;
    
    [Header("GAMEOPTION")]
    [Tooltip("คะแนนเพื่อผ่าน")]
    public int ScoretoPass;
    [Tooltip("เวลาในเกม")]
    public float TimeOut;

    [Header("INFORMATIONLAVEL")]
    public int Level;
    #endregion
    #region public static Values
    public static float timeleft;
    public static int point;
    public static int LevelS;

    public static float Timeout;
    public static int scoretoPass;
    public static int Easy=0;
    public static int Normal=0;
    public static int Hard=0;
    public static bool isCutPoint;
    public static bool isCutPointWong;
    #endregion
    // Use this for initialization
    void Start () {
       
        Timeout = TimeOut;
        scoretoPass = ScoretoPass;
        isCutPoint = cutPointformtimeout;
        isCutPointWong = cutPointformWrongTyping;
        LevelS = Level;
        Gameover.isGAmeOver = false;
        #region Give Value to Mode
        
        if (isEasy&&!isNormal&&!isHard)
        {
            Easy = 1;
            
        }
        else if (!isEasy && isNormal && !isHard)
        {
            
            Normal = 1;
            
        }
        else if (!isEasy && !isNormal && isHard)
        {
            
            Hard = 1;
        }
        else if (isEasy && isNormal&&!isHard)
        {
           
            Easy = 1;
            Normal = 1;
            Hard = 0;
        }
        else if (isNormal && isHard&&!isEasy)
        {
            
            Easy = 0;
            Normal = 1;
            Hard = 1;

        }
        else if (isEasy && isNormal && isHard)
        {
            
            Easy = 1;
            Normal = 1;
            Hard = 1;
        }
        #endregion 
    }

    // Update is called once per frame
    void Update () {
        
            point = Score.Like_point;
            timeleft = timecount.timeingame;
               
    }
}
