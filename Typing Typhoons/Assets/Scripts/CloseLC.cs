using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseLC : MonoBehaviour {
    public GameObject panal;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void closePanal()
    {
        panal.SetActive(false);
    }
}
