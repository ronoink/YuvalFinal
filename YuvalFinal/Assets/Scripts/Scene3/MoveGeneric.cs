using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGeneric : MonoBehaviour
{
    public float moveSpeed;
  //  public GameObject startHallMove;
  //  public Animator startPlayeranim;
  //  public GameObject startPlayerMove;
  //  public Animator baloonAnimStop; 
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        transform.Translate(0,-moveSpeed ,0);
    }


    
}
