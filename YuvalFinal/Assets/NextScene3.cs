using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NextScene3 : MonoBehaviour
{
    public GameObject stopHallMove;
    
    // Start is called before the first frame update
    void Start()
    {

    }
    

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            stopHallMove.GetComponent<MoveBG>().moveSpeed = 0;
            Invoke("nextscene", 0.1f);   
        }

        
    }
    

    
    void nextscene()
    { 
        SceneManager.LoadScene(9);
    }

    
}