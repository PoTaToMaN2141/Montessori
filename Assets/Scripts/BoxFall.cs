using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxFall : MonoBehaviour
{
    public Collider collider;
    public Rigidbody rigidBody;
    public BounceObject bounceDetails;
    private float bounceMultiplier = 1;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (bounceMultiplier + Input.mouseScrollDelta.normalized.y/10 >= 0)
        {
            bounceMultiplier += Input.mouseScrollDelta.normalized.y/10;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            animator.SetBool("Big", true);
        }
        else
        {
            animator.SetBool("Big", false);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        rigidBody.velocity = -1 * rigidBody.velocity * bounceDetails.bounceAmount * bounceMultiplier;
    }
}
