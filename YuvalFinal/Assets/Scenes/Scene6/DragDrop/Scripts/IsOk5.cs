using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsOk5 : MonoBehaviour
{
    public GameObject solution;
    public int one = 1;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Word5") )
        {
            solution.GetComponent<Solution>().solution += one;
            print("YAY5 !!!!!");
        }
    }
  
    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Word5") )
        {
            solution.GetComponent<Solution>().solution -= one;
            print("WOOOO5 !!!!!");
        }

    }
  
  
  
}