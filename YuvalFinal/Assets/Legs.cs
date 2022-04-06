using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Legs : MonoBehaviour
{
    public SpriteRenderer sr;
    public Sprite[] spriteArray;
    
    public void Sneakers()
    {
        print("Sneakers");
        this.GetComponent<SpriteRenderer>().sprite = spriteArray[0];
    }
    
    public void Hills()
    {
        print("Hills");
         this.GetComponent<SpriteRenderer>().sprite = spriteArray[1];
    }
    public void Flipflops()
    {
        print("Flipflops");
        this.GetComponent<SpriteRenderer>().sprite = spriteArray[2];
    }
    
    public void RedDress()
    {
        print("RedDress");
        this.GetComponent<SpriteRenderer>().sprite = spriteArray[3];
    }
    
}
