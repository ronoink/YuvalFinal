using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene1Win : MonoBehaviour
{
    public int a = 0;
    public int b = 0;
    public int c = 0;
    public int d = 0;
    // Start is called before the first frame update
    public int winner;
    public int four = 4;
    public GameObject character;
    public Sprite happy;
    public GameObject wintext;
    public Animator anim;
    public Animator anim2;
    public GameObject bubble2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        win();
        
        if (winner == four)
        {
            print("success");
            character.GetComponent<SpriteRenderer> ().sprite = happy;
            wintext.SetActive(true);
            anim.SetBool("happy" , true);
            bubble2.gameObject.SetActive(true);
            anim2.SetBool("bubble2" , true );
        }

    }

    public void pressA0()
    {
        a = 0;
    }
    
    public void pressA1()
    {
        a = 1;
    }
    
    public void pressB0()
    {
        b = 0;
    }
    
    public void pressB1()
    {
        b = 1;
    }
    
        
    public void pressC0()
    {
        c = 0;
    }
    
    public void pressC1()
    {
        c = 1;
    }

    
    public void pressD1()
    {
        d = 1;
    }
    public void win()
    {
        winner = a + b + c + d;
    }
}
