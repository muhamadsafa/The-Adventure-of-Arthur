using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    public float ms;
    public float jf;
    public LayerMask ground;
    public Animator animator;
    private Vector3 RespawnPoint;
    public GameObject FallDetector;
    



    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
        RespawnPoint = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float horiz = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(ms * horiz, rb.velocity.y);
        animator.SetFloat("Speed", Mathf.Abs(horiz));

       if(horiz > 0 || horiz < 0)
        {
            transform.localScale = new Vector2(1.371797f * horiz, 1.371797f);
        }

       if (Input.GetKeyUp(KeyCode.Space))
        {

            if (!IsGrounded())
            {
                
                return;
            }
            else
            {
                rb.velocity = Vector2.up * jf;
            }
        }
       bool IsGrounded()
        {
            Vector2 position = transform.position;
            Vector2 dircetion = Vector2.down;
            float distance = 1.0f;
            RaycastHit2D hit = Physics2D.Raycast(position, dircetion, distance, ground);
            if (hit.collider != null)
            {
                return true;
               
                
            }
            return false;
        }
        FallDetector.transform.position = new Vector2(transform.position.x, FallDetector.transform.position.y);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "fallDetector")
        {
            
            transform.position = RespawnPoint;
            

        }
        else if (collision.tag == "checkpoint")
        {
            RespawnPoint = transform.position;
        }
    }

   
}
