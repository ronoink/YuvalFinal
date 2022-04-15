using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteScript : MonoBehaviour
{

    public Transform target;
    public float zOffset;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LateUpdate()
    {
        transform.localPosition =
            new Vector3(target.localPosition.x, transform.localPosition.y, target.localPosition.z + zOffset);
    }
}
