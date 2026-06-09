using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 10f;

    public Rigidbody2D rb;

    private Vector2 movement;

    public SpriteRenderer[] parts;


    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        movement = movement.normalized;

        if (movement.x > 0)
        {
            SetFlip(false);
        }
        else if (movement.x < 0)
        {
            SetFlip(true);
        }
    }

    void FixedUpdate()
    {
        rb.linearVelocity = movement * moveSpeed;
    }

    void SetFlip(bool flip)
    {
        foreach (var p in parts)
        {
            p.flipX = flip;
        }
    }
}
