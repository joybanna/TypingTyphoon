using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyNPC : MonoBehaviour {
    public GameObject spriteA;
    private NPCTransform die;
    private Animator anim;
    // Use this for initialization
    void Start ()
    {
        anim = spriteA.GetComponent<Animator>();
        die = GetComponent<NPCTransform>();
    }
	
	// Update is called once per frame
	void Update () {
        if (NPCTransform.isDes)
        {
            anim.SetTrigger("isDes");            
            StartCoroutine(delaydie());
        }
    }
    IEnumerator delaydie()
    {        
        yield return new WaitForSeconds(0.6f);
        PeopleMove.isSpawn = true;
        Destroy(this.gameObject);       
    }
}
