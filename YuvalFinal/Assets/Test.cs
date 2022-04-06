using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Test : MonoBehaviour
{
   // public SpriteRenderer Avatar;
    public GameObject avatar;
 //   public Sprite newSprite;
    public Sprite[] spriteArray;

  public void Update()
  {
      if (Input.GetMouseButtonDown(0))
     ChangeSprite();
  }

  public void ChangeSprite()
    {
        avatar.GetComponent<SpriteRenderer>().sprite = spriteArray[0];
    }

}