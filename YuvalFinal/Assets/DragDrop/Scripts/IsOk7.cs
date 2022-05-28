using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsOk7 : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Word7") )
        {
            print("YAY7 !!!!!");
        }
    }
  
    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Word7") )
        {
            print("WOOOO7 !!!!!");
        }

    }
  
  
  
}