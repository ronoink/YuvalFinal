using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsOk1 : MonoBehaviour
{
  public void OnTriggerEnter2D(Collider2D other)
  {
    if (other.gameObject.CompareTag("Word1") )
    {
      print("YAY !!!!!");
    }
  }
  
  public void OnTriggerExit2D(Collider2D other)
  {
    if (other.gameObject.CompareTag("Word1") )
    {
      print("WOOOO !!!!!");
    }
  }
  
}
