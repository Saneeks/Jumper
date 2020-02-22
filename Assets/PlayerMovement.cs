using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    int JumpsLeft;
    Rigidbody2D rb;
    public float force;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        JumpsLeft = 0;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {
            JumpsLeft = 2;
        }
    }
    void Update()
    {

        if ((!Input.GetKeyDown("space") && Input.GetKey("space")))
        {
            rb.gravityScale = 2;
        }
        else
        {
            rb.gravityScale = 6;
        }
        if (Input.GetKeyDown("space") && JumpsLeft > 0)
        {
            rb.AddForce(transform.up * force, ForceMode2D.Impulse);
            JumpsLeft--;
        }
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase != TouchPhase.Began)
            {
                rb.gravityScale = 6;
            }
            if (touch.phase == TouchPhase.Began)
            {
                rb.AddForce(transform.up * force, ForceMode2D.Impulse);
                JumpsLeft--;
            }
            else if (touch.phase == TouchPhase.Moved || touch.phase == TouchPhase.Stationary)
            {
                rb.gravityScale = 2;
            }
        }
    }
}
