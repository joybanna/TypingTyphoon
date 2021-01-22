using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonCavas : MonoBehaviour {

   public void Tryagain()
    {
        //print("save is comming soon");
        SceneManager.LoadScene(GameController.LevelS);
        //Loading.isLoading = false;
    }
    public void GotoMap()
    {
        //print("gotomap");
        StoryTell.isRun = false;
        SceneManager.LoadScene(8);
        //Loading.isLoading = false;
    }
   public void Mainmenu()
    {
        //print("mianmenu");
        SceneManager.LoadScene(0);
        //Loading.isLoading = false;
    }
    public void Play()
    {
        //print("play");
        SceneManager.LoadScene(9);
       // Loading.isLoading = false;
    }
    public void Exit()
    {
        Application.Quit();
    }
    


}
