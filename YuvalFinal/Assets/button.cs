using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    public SpriteRenderer sr;
    public Sprite[] spriteArray;
    
    public void Shirtred()
    {
        print("red");
         this.GetComponent<SpriteRenderer>().sprite = spriteArray[1];
    }
    public void Shirtgreen()
    {
        print("green");
        this.GetComponent<SpriteRenderer>().sprite = spriteArray[2];
    }
}
