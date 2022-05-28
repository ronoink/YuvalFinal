using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsOk4 : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Word4") )
        {
            print("YAY4 !!!!!");
        }
    }
  
    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Word4") )
        {
            print("WOOOO4 !!!!!");
        }

    }
  
  
  
}