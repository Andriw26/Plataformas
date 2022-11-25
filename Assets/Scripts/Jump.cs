using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float force = 1000;
    Rigidbody2D rb;
    Animator animator;
    GroundDetector ground;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ground = GetComponent<GroundDetector>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(ground.grounded == true && Input.GetButtonDown("Jump"))
        {
            rb.AddForce(new Vector2(0, force));
            animator.SetTrigger("Jumping");
        }
    }

}