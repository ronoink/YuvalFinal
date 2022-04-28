using System.Collections;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveTime2 : MonoBehaviour
{
    public GameObject timer;

    public float timeRemains;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        timeRemains = timer.GetComponent<Timer2>().timeRemaining;
        print(timeRemains);
    }

    public void setSaveTime()
    {
        PlayerPrefs.SetFloat("SetTimer" , timeRemains);
        print(timeRemains);
    }
}
