using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsOk4 : MonoBehaviour
{
    public GameObject solution;
    public int one = 1;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Word4") )
        {
            solution.GetComponent<Solution>().solution += one;
            print("YAY4 !!!!!");
        }
    }
  
    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Word4") )
        {
            solution.GetComponent<Solution>().solution -= one;
            print("WOOOO4 !!!!!");
        }

    }
  
  
  
}