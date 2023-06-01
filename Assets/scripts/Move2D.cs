using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move2D : MonoBehaviour
{
    public Rigidbody2D rb;
    public int moveSpeed;
    private float direction;

    private Vector3 facingRight;
    private Vector3 facingLeft;

    public bool groundVerify;
    public Transform groundDetected;
    public LayerMask ground;

    void Start()
    {
        facingRight = transform.localScale;
        facingLeft = transform.localScale;
        facingLeft.x = facingLeft.x * -1;
        rb = GetComponent<Rigidbody2D>(); 
    }

    void Update()
    {

        groundVerify = Physics2D.OverlapCircle(groundDetected.position, 0.2f, ground);

        if (Input.GetButtonDown("Jump") && groundVerify == true)
        {
            rb.velocity = Vector2.up * 12;
        }

        direction = Input.GetAxis("Horizontal");

        if (direction > 0)
        {
            transform.localScale = facingRight;
        }

        if (direction < 0)
        {
            transform.localScale = facingLeft;
        }

        rb.velocity = new Vector2(direction * moveSpeed, rb.velocity.y);
    }
}
