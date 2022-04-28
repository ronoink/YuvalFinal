using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{

    public GameObject pickup;
    public GameObject OpenDoor;
    public GameObject ColorPickup;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        pickup.gameObject.SetActive(false);
        print("collisionok");
        OpenDoor.GetComponent<OpenDoor>().pickupDoor++;
        ColorPickup.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 1f);

    }
    

    
}
