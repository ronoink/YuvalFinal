using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UIElements;

public class Baloon : MonoBehaviour
{

    public GameObject baloon;
   // public Vector3 pos = new Vector3(0f, 0 , 0f);
    //public Vector3 pos2 = new Vector3(-1.29f, 0 , 0f);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      //pos = baloon.GetComponent<Transform>().position;
        if (baloon.transform.position.x >= 2.7f)
        {
            //baloon.transform.position = new Vector3(pos.x ,transform.position.y ,transform.position.z );
            baloon.GetComponent<SpriteRenderer>().flipX = false;
        }
        if (baloon.transform.position.x <= 0f)
        {
          //  baloon.transform.position = new Vector3(pos2.x ,transform.position.y ,transform.position.z );
            baloon.GetComponent<SpriteRenderer>().flipX = true;
        }
      
    }
}
