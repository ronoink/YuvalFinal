using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsOk6 : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Word6") )
        {
            print("YAY6 !!!!!");
        }
    }
  
    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Word6") )
        {
            print("WOOOO6 !!!!!");
        }

    }
  
  
  
}