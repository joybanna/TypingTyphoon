using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;
using UnityEngine.SceneManagement;

public class SaveGame : MonoBehaviour
{   
    public static bool isSave;
    public static bool isLoad;
    // Use this for initialization
    void Start () {
		
	}
	// Update is called once per frame
	void Update () {		
	}
    public void Save()
    {
        DeletePlay();
        StartCoroutine(OneWait());
        //Loading.isLoading = false;
    }   
    public void Load()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("Level", GameController.LevelS));
        isLoad = true;
        //Loading.isLoading = false;
    }
    public void DeletePlay()
    {
        PlayerPrefs.DeleteKey("Lavel");       
    }
    public static void SavePlay()
    {
        PlayerPrefs.SetInt("Level", GameController.LevelS);
        //Loading.isLoading = false;
    }
    IEnumerator OneWait()
    {
        yield return new WaitForSeconds(1.0f);
        SavePlay();
    }

}
