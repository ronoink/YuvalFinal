using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollidePlayer : MonoBehaviour
{

    public GameObject baloon;
    public Animator baloonAnim;
    public Animator playerStopanim;




        // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Character")
        baloon.gameObject.SetActive(true);
        baloonAnim.GetComponent<Animator>().SetBool("BaloonStart" , true);
        playerStopanim.GetComponent<Animator>().SetBool("PlayerStopAnim" , true);
        print("playerCollideOK");
       
       
       // characterstopanimation.GetComponent<Animator>().SetBool("CharacterStop" , true);
        
    }


  /*  public void PlayerStart()
    {
        playerstartanimation.GetComponent<Animator>().SetBool("PlayerStop" , true);
        StartMove.GetComponent<Move>().moveSpeed = 1;
    }
  */  
}
