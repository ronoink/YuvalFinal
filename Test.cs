using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public GameObject Avatar;
    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;

    
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            ChangeSprite();
        }
    }
    
    void ChangeSprite()
    {
      //  spriteRenderer.sprite = newSprite;
        Avatar.GetComponent<SpriteRenderer>().sprite = newSprite;
    }
   /* public GameObject newSprite;
    void OnMouseDown()
    {
        // Destroy the gameObject after clicking on it
        newSprite.
    }
    */
}

