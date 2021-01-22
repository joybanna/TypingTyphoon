using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoretoClear : MonoBehaviour {
    private int PointtoPass;
	// Use this for initialization
	void Start () {
        PointtoPass = GameController.scoretoPass;
        stateclear.isStateClear = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (Score.Like_point >= PointtoPass)
        {
            StartCoroutine(Clear());
        }
        else if (Score.Like_point < 0&&GameController.isCutPoint)
        {
            StartCoroutine(Over());
        }
        else
        {
            stateclear.isStateClear = false;
        }
	}
    IEnumerator Clear()
    {
        yield return new WaitForSeconds(2f);
        stateclear.isStateClear = true;
        WordTimer.isReady = false;
    }
    IEnumerator Over()
    {
        yield return new WaitForSeconds(2f);
        Gameover.isGAmeOver = true;
    }
}
