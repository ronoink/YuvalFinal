using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLose : MonoBehaviour
{

    public GameObject timerRef;
    public float time123;
    public GameObject Lose;
    
        

    
    // Start is called before the first frame update
    void Start()
    { 
      
    }

    // Update is called once per frame
    void Update()
    {
        time123 = timerRef.GetComponent<Timer1>().timeRemaining;
        TimeOver();
    }

    void TimeOver()
    {
        if (time123 <= 0.1f)
        {
            Lose.SetActive(true);
        }
    }

    
    
}
