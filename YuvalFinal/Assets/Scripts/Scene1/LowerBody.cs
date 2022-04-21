using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LowerBody : MonoBehaviour
{
    public SpriteRenderer sr;
    public Sprite[] spriteArray;
    
    public void GreenShorts()
    {
        print("GreenShorts");
        this.GetComponent<SpriteRenderer>().sprite = spriteArray[0];
    }
    
    public void BlueJeans()
    {
        print("BlueJeans");
         this.GetComponent<SpriteRenderer>().sprite = spriteArray[1];
    }
    public void BlueSkirt()
    {
        print("BlueSkirt");
        this.GetComponent<SpriteRenderer>().sprite = spriteArray[2];
    }
    
    public void BlackPants()
    {
        print("BlackPants");
        this.GetComponent<SpriteRenderer>().sprite = spriteArray[3];
    }

    public void ColorPants()
    {
        print("ColorPants");
        this.GetComponent<SpriteRenderer>().sprite = spriteArray[4];
    }

    
}
