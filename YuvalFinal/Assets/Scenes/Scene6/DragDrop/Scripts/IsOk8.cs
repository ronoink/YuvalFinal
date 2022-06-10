using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsOk8 : MonoBehaviour
{
    
    public GameObject solution;
    public int one = 1;
    
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Word8") )
        {
            solution.GetComponent<Solution>().solution += one;
            print("YAY8 !!!!!");
        }
    }
  
    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Word8") )
        {
            solution.GetComponent<Solution>().solution -= one;
            print("WOOOO8 !!!!!");
        }

    }
  
  
  
}