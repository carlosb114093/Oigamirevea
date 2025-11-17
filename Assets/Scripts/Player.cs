using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5;
    private Rigidbody2D rb2D;

    private float move;
    public float jumpForce =4;
    private bool isGrounded;
    public Transform groundCheck;
    public float groundRadious=0.1f;
    public LayerMask groundLayer;


    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        move= Input.GetAxisRaw("Horizontal");
        rb2D.linearVelocity = new Vector2(move*speed,rb2D.linearVelocity.y);

        if (move != 0 )
        transform.localScale = new Vector3(Mathf.Sign(move) * Mathf.Abs(transform.localScale.x),
                                   transform.localScale.y,
                                   transform.localScale.z);


    }
}

