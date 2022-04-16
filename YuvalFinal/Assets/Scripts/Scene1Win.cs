using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene1Win : MonoBehaviour
{
    public int a = 0;
    public int b = 0;
    public int c = 0;
    // Start is called before the first frame update
    public int winner;
    public int three = 3;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        win();
        
        if (winner == three)
        {
            print("winner");
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

    public void win()
    {
        winner = a + b + c;
    }
}
