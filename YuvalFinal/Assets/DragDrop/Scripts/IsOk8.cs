using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsOk8 : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Word8") )
        {
            print("YAY8 !!!!!");
        }
    }
  
    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Word8") )
        {
            print("WOOOO8 !!!!!");
        }

    }
  
  
  
}