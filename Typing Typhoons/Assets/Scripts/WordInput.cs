using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordInput : MonoBehaviour {

	public WordManager wordManager;

	// Update is called once per frame
	void Update () {
        if (NPCTransform.isStop&&stateclear.isStateClear==false&&Gameover.isGAmeOver==false)
        {
            foreach (char letter in Input.inputString)
            {
                wordManager.TypeLetter(letter);
            }
        }
		
	}

}
