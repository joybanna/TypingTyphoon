using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordTimer : MonoBehaviour {

	public WordManager wordManager;
    public static bool isWord = true;
	public float wordDelay = 1f;
	private float nextWordTime = 1f;
    public static bool isReady;
    private void Start()
    {
        isReady = true;
    }

    private void Update()
	{        
        if (isReady)
        {
           if(Input.GetKeyUp(KeyCode.Space))
            {
                isReady = false;
            }
        }       
        if (isWord&& !isReady)
        {
           if (Time.time >= nextWordTime)
           {
              wordManager.AddWord();
              nextWordTime = Time.time + wordDelay;
              wordDelay *= 1f;
              isWord = false;
           }
        }
        
    }

}
