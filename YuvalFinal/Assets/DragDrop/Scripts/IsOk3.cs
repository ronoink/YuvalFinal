using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsOk3 : MonoBehaviour
{
  public void OnTriggerEnter2D(Collider2D other)
  {
    if (other.gameObject.CompareTag("Word3") )
    {
      print("YAY3 !!!!!");
    }
   }
  
  public void OnTriggerExit2D(Collider2D other)
  {
    if (other.gameObject.CompareTag("Word3") )
    {
      print("WOOOO3 !!!!!");
    }

  }
  
  
  
}
