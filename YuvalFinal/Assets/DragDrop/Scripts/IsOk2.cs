using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsOk2 : MonoBehaviour
{
    public GameObject solution;
    public int one = 1;
   
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Word2") )
        {
            solution.GetComponent<Solution>().solution += one;
            print("YAY2 !!!!!");
        }
    }
  
    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Word2") )
        {
            solution.GetComponent<Solution>().solution -= one;
            print("WOOOO2 !!!!!");
        }

    }
  
  
  
}