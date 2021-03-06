using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBG : MonoBehaviour
{
    public float moveSpeed = 0.05f;
    public GameObject startHallMove;
    public Animator startPlayeranim;
    public GameObject startPlayerMove;
    public Animator baloonAnimStop; 
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        transform.Translate(0,-moveSpeed ,0);
    }

    private void Update()
    {
       // moveSpeed += 0.000001f;
    }

    public void StartBg()
    {
        startHallMove.GetComponent<MoveBG>().moveSpeed = 0.08f ;
        startPlayeranim.GetComponent<Animator>().SetBool("PlayerStopAnim" , false);
        startPlayerMove.GetComponent<Move>().moveSpeed = 5f;
        baloonAnimStop.GetComponent<Animator>().SetBool("BaloonStart" , false);
    }
    
}
