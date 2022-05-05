using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{


    public float moveSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TouchMove();
    }

    private void FixedUpdate()
    {
        

    }

    void TouchMove()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if (mousePos.x > 0.1f)
            {
                transform.Translate(moveSpeed * Time.deltaTime,0,0 );
            }
            else if (mousePos.x < -0.1f)
            {
                transform.Translate(-moveSpeed  * Time.deltaTime,0,0);
            }
            
        }

    }


    
}
