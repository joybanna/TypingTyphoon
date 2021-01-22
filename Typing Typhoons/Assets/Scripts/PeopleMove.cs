using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeopleMove : MonoBehaviour {

    public GameObject[] movepoint;
    public GameObject[] NPC;
    public static bool isSpawn;
    public bool isNPC;
    
	// Use this for initialization
	void Start () {
       isNPC = false;
       isSpawn = false;
        
	}	
	// Update is called once per frame
	void Update ()
    {
        RandomSpawn();
    }
    public  void RandomNPC()
    {
        if (isSpawn)
        {
            int randomIndex = Random.Range(0, NPC.Length);
            Instantiate(NPC[randomIndex], movepoint[0].transform.position, Quaternion.identity);
            isSpawn = false;
        }                   
                                                                          
    }
    public void RandomSpawn()
    {
        int randomSpawn = Random.Range(0, 0);
        StartCoroutine(delaySpawn(randomSpawn));
        
    }
   IEnumerator delaySpawn(int time)
    {
        yield return new WaitForSeconds(time);
        RandomNPC();
    }
   
   
   
}
