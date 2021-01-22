using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroy : MonoBehaviour {
    
    private void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("music");

        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (SceneManager.GetActiveScene().name == "arcadeLevel")
        {
            Destroy(this.gameObject);
        }
        else if (SceneManager.GetActiveScene().name == "level1")
        {
            Destroy(this.gameObject);
        }
        else if (SceneManager.GetActiveScene().name == "level2")
        {
            Destroy(this.gameObject);
        }
        else if (SceneManager.GetActiveScene().name == "level3")
        {
            Destroy(this.gameObject);
        }
        else if (SceneManager.GetActiveScene().name == "level4")
        {
            Destroy(this.gameObject);
        }
        else if (SceneManager.GetActiveScene().name == "level5")
        {
            Destroy(this.gameObject);
        }
        else if (SceneManager.GetActiveScene().name == "level6")
        {
            Destroy(this.gameObject);
        }
        else if (SceneManager.GetActiveScene().name == "level7")
        {
            Destroy(this.gameObject);
        }
        else if (SceneManager.GetActiveScene().name == "story")
        {
            Destroy(this.gameObject);
        }
        else if (SceneManager.GetActiveScene().name == "MainlevelChose")
        {
            Destroy(this.gameObject);
        }
        
    }
}
