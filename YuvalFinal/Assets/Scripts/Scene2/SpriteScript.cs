using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AI;

public class SpriteScript : MonoBehaviour
{

    public Transform target;
    public float zOffset;

    private Animator animator;
    public NavMeshAgent myAgent;
    public GameObject player;
    
    
    public Vector3 up1 = new Vector3(0.5f, 0.5f, 0.5f);
    public Vector3 midup1 = new Vector3(0.55f, 0.55f, 0.55f);
    public Vector3 mid1 = new Vector3(0.6f, 0.6f, 0.6f);
    public Vector3 midlow1 = new Vector3(0.65f, 0.65f, 0.65f);
    public Vector3 low1 = new Vector3(0.7f, 0.7f, 0.7f);
    
    
    // Start is called before the first frame update
    void Start()
    {

        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {

        if (myAgent.velocity.x == 0)
        {
            animator.SetInteger("Direction", 0);
        }
        else if (myAgent.velocity.z > 0.5f)
        {
            animator.SetInteger("Direction", 1);
        }  
         else if (myAgent.velocity.z < -0.5f)
        {
            animator.SetInteger("Direction", 2);
        }  
        else if (myAgent.velocity.x > 0.3f)
        {
            animator.SetInteger("Direction", 3);
        }  
        else if (myAgent.velocity.x < -0.3f)
        {
            animator.SetInteger("Direction", 4);
        }

        scale();   

    }

    void LateUpdate()
    {
        transform.localPosition =
            new Vector3(target.localPosition.x, transform.localPosition.y, target.localPosition.z + zOffset);
    

    }

    void scale()
    {
        if (player.transform.position.z <= 3.3f && player.transform.position.z >=1.4f)
        {
            player.transform.localScale = up1;
        }
        
        if (player.transform.position.z <= 1.4f && player.transform.position.z >=0)
        {
            player.transform.localScale = midup1;
        }
        
        if (player.transform.position.z <= 0f && player.transform.position.z >=-1.0f)
        {
            player.transform.localScale = mid1;
        }
        
        if (player.transform.position.z <= -2.0f && player.transform.position.z >=-2.8f)
        {
            player.transform.localScale = midlow1;
        }
        
        if (player.transform.position.z <= -2.8f )
        {
            player.transform.localScale = low1;
        }
    }
}
