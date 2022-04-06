using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hair : MonoBehaviour
{
    public SpriteRenderer sr;
    public Sprite[] spriteArray;
    
    public void Kukiot()
    {
        print("kukiot");
        this.GetComponent<SpriteRenderer>().sprite = spriteArray[0];
    }
    
    public void Kuku()
    {
        print("kuku");
         this.GetComponent<SpriteRenderer>().sprite = spriteArray[1];
    }
    public void Kare()
    {
        print("Kare");
        this.GetComponent<SpriteRenderer>().sprite = spriteArray[2];
    }
}
