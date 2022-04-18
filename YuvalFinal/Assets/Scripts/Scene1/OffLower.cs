using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffLower : MonoBehaviour
{

    public GameObject e;
    public GameObject f;
    public GameObject g;

    
    
    public void OffE()
    {
        e.SetActive(false);
        f.SetActive(true);
        g.SetActive(true);

     
    }

    public void OffF()
    {
        e.SetActive(true);
        f.SetActive(false);
        g.SetActive(true);
 

    
    }
    
    public void OffG()
    {
        e.SetActive(true);
        f.SetActive(true);
        g.SetActive(false);
 

    
    }


    
    
    
    
}
