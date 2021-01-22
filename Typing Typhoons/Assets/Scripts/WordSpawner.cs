using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordSpawner : MonoBehaviour
{
	public GameObject wordPrefab;
    public GameObject pointSpawner;
	public Transform wordCanvas;
	public WordDisplay SpawnWord ()
	{       
            GameObject wordObj = Instantiate(wordPrefab, pointSpawner.transform.position, Quaternion.identity, wordCanvas);
            WordDisplay wordDisplay = wordObj.GetComponent<WordDisplay>();
            return wordDisplay;       
    }

}
