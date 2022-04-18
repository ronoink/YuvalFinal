using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffUpper : MonoBehaviour
{

    public GameObject a;
    public GameObject b;
    public GameObject c;
    public GameObject d;

    
    
    public void OffA()
    {
        a.SetActive(false);
        b.SetActive(true);
        c.SetActive(true);
        d.SetActive(true);

     
    }

    public void OffB()
    {
        a.SetActive(true);
        b.SetActive(false);
        c.SetActive(true);
        d.SetActive(true);

    
    }
    
    public void OffC()
    {
        a.SetActive(true);
        b.SetActive(true);
        c.SetActive(false);
        d.SetActive(true);

    
    }
    
    public void OffD()
    {
        a.SetActive(true);
        b.SetActive(true);
        c.SetActive(true);
        d.SetActive(false);

    
    }
    
    
    
    
}
