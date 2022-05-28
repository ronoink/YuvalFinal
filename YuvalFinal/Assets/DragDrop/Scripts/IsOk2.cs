using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsOk2 : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Word2") )
        {
            print("YAY2 !!!!!");
        }
    }
  
    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Word2") )
        {
            print("WOOOO2 !!!!!");
        }

    }
  
  
  
}