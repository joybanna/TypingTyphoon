using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour {
    public GameObject LoadingCanvas;
    public static bool isLoading;
	// Use this for initialization
	void Start () {
        isLoading = false;
        WordTimer.isReady = true;
        
	}
	
	// Update is called once per frame
	void Update () {
        if (!isLoading)
        {
            Time.timeScale = 1f;
            LoadingCanvas.SetActive(true);
            StartCoroutine(delayLoad());
        }
        else if (isLoading)
        {
            LoadingCanvas.SetActive(false);           
        }
	}
    IEnumerator delayLoad()
    {
        yield return new WaitForSeconds(1f);
        isLoading = true;
        
    }
   
}
