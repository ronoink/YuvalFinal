using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{

    public int pickupDoor = 0;

    public GameObject Door;
    public GameObject Baloon;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (pickupDoor == 3)
        {
            Door.gameObject.SetActive(true);
            WaitDestroyBaloon();
        }
    }


        public void WaitDestroyBaloon()
        {
            Invoke(nameof(DestroyBaloon), 1);
        }

        public void DestroyBaloon()
        {
            Baloon.gameObject.SetActive(false);
        }
}

