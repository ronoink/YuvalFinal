using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
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
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
            
            PlayerPrefs.SetFloat("SetTimer2" , timeRemains);
            print("nextScene");
        SceneManager.LoadScene(4);




    }
    

    
}