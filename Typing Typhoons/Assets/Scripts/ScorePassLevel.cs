using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorePassLevel : MonoBehaviour {
    public string Level = "";
    private int scoreEnd;

    void SaveScore()
    {
        scoreEnd = Score.Like_point;
        PlayerPrefs.SetInt(Level, scoreEnd);
    }

}
