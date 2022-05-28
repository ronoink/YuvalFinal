using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsOk5 : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Word5") )
        {
            print("YAY5 !!!!!");
        }
    }
  
    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Word5") )
        {
            print("WOOOO5 !!!!!");
        }

    }
  
  
  
}