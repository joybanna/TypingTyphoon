using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryTell : MonoBehaviour {
    private Animator anim;
    public static bool isRun;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        isRun = false;
        if (isRun)
        {
            StartCoroutine(wait());
        }

    }
	
	// Update is called once per frame
	void Update ()
    {         
        if (!isRun)
        {
            Time.timeScale = 1f;
            anim.SetBool("isPlay",true);
            isRun = true;
        }
	}
    IEnumerator wait()
    {
        yield return new WaitForSeconds(1f);
        isRun = false;
    }
}
