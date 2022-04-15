using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SpriteScript : MonoBehaviour
{

    public Transform target;
    public float zOffset;

    private Animator animator;
    public NavMeshAgent myAgent;
    
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
        else if (myAgent.velocity.z > .5f)
        {
            animator.SetInteger("Direction", 1);
        }  
         else if (myAgent.velocity.z < -.5f)
        {
            animator.SetInteger("Direction", 2);
        }  
        else if (myAgent.velocity.x > .5f)
        {
            animator.SetInteger("Direction", 3);
        }  
        else if (myAgent.velocity.x < -.5f)
        {
            animator.SetInteger("Direction", 4);
        }
    }

    void LateUpdate()
    {
        transform.localPosition =
            new Vector3(target.localPosition.x, transform.localPosition.y, target.localPosition.z + zOffset);
    }
}
