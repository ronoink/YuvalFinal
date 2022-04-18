using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpperBody : MonoBehaviour
{
    public SpriteRenderer sr;
    public Sprite[] spriteArray;
    
    public void BlueShirt()
    {
        print("BlueShirt");
        this.GetComponent<SpriteRenderer>().sprite = spriteArray[0];
    }
    
    public void BlackShirt()
    {
        print("BlackShirt");
         this.GetComponent<SpriteRenderer>().sprite = spriteArray[1];
    }
    public void YellowShirt()
    {
        print("YellowShirt");
        this.GetComponent<SpriteRenderer>().sprite = spriteArray[2];
    }
    
    public void RedDress()
    {
        print("RedDress");
        this.GetComponent<SpriteRenderer>().sprite = spriteArray[3];
    }
    
}
