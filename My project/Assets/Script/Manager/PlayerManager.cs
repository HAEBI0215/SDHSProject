using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 5f;

    private Rigidbody2D rb;
    private Vector2 moveInput;
    private bool isGrounded;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        Move();
    }

    public void MoveInput(float horizontal, float vertical)
    {
        moveInput = new Vector2(horizontal, vertical);
    }

    public void JumpInput()
    {
        if (isGrounded)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }

    private void Move()
    {
        Vector2 velocity = rb.velocity;
        velocity.x = moveInput.x * moveSpeed;
        rb.velocity = velocity;
    }
}
