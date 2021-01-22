using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCTransform : MonoBehaviour {
    public GameObject spriteA;
    public static bool isDes;
    private bool isStand;
    public static bool isStop;
    private DestroyNPC one;
    private Animator anim;
    private int count;
	// Use this for initialization
	void Start () {
        anim = spriteA.GetComponent<Animator>();
        one = GetComponent<DestroyNPC>();
        isDes = false;
        isStand=false;
        isStop = false;
        one.enabled = false;
        count = 0;
    }	
	// Update is called once per frame
	void Update () {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right, 4f);
        Debug.DrawRay(transform.position, Vector2.right * 4f, Color.red);
        if (isStand)
        {
            if (!isDes)
            {
                if (!isStop)
                {
                    anim.SetBool("isWalk", true);
                    transform.Translate(5f * Time.deltaTime, 0, 0);
                }
                else if (hit.collider)
                {                    
                    anim.SetBool("isWalk", false);
                    isStop = true;
                    
                    transform.Translate(0, 0, 0);
                    if (isStop)
                    {                       
                        if (count==0)
                        {
                            SoundManager.isStopMove = true;
                            WordTimer.isReady = false;
                            WordTimer.isWord = true;
                            count = 1;
                        }                       
                    }
                }                
            }
            
        }                         
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground")
        {                       
            isStand = true;
        }       
        if (collision.gameObject.tag == "stoppoint")
        {
            isStop = true;
            one.enabled = true;
        }
    }
    
}
