using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class choselevel : MonoBehaviour {
    [SerializeField]private int level;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void LevelChose()
    {
        SceneManager.LoadScene(level);
        Loading.isLoading = false;
    }
}
