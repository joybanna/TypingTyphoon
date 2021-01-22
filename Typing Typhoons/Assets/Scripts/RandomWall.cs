using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomWall : MonoBehaviour {
    public Sprite[]img;
    public SpriteRenderer sR;
    int R;
	// Use this for initialization
	void Start ()
    {
        R =Random.Range(0, 6);
        sR.sprite = img[R];
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

}
