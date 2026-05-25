using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Pelihahmon liikkumisnopeus
    public float moveSpeed = 10f;

    // Pelihahmon rigidbody törmäysten tunnistusta varten
    private Rigidbody2D rb;

    // Tallentaa liikkumisnopeuden ja suunnan
    private Vector2 movement;

    // Pelihahmon osat flippausta varten
    public SpriteRenderer[] parts;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Katsotaan mihin suuntaan pelaaja liikkuu
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        // Normalisoi liikkumisen
        movement = movement.normalized;

        // Flippaa pelihahmon, jos suunta vaihtuu
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
        // Liikuttaa pelihahmoa
        rb.linearVelocity = movement * moveSpeed;
    }

    void SetFlip(bool flip)
    {
        // Flippaa osa kerrallaan pelihahmon
        foreach (var p in parts)
        {
            p.flipX = flip;
        }
    }

    // Palauttaa pelihahmon liikkeen animaatioita varten
    public Vector2 GetMovement()
    {
        return movement;
    }
}
