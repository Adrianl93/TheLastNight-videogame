using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    private float _horizontalDirection;
    public float speed = 4;
    public float jumpForce = 15;
    private SpriteRenderer _spriteRenderer;
    private Rigidbody2D _rigidBody2D;
    public LayerMask groundLayer;
    public bool isGrounded;
    public Transform groundCheckPosition;
    public float groundCheckRadius;

    private Collider2D _collider;
   


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rigidBody2D = GetComponent<Rigidbody2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _collider = GetComponent<Collider2D>();


    }

    // Update is called once per frame
    void Update()
    {
        Run();
        Jump();

        


    }


    private void Run()
    {

        _horizontalDirection = Input.GetAxisRaw("Horizontal");
        _rigidBody2D.linearVelocityX = _horizontalDirection * speed;
        if (_horizontalDirection != 0)
        {
            _spriteRenderer.flipX = _horizontalDirection < 0;
        }
    }

    private void Jump()
    {
        //if (!_collider.IsTouchingLayers(LayerMask.GetMask("ground")))
        //{
        //    return;
        //}

        //if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.Space))
        //{
        //    _rigidBody2D.AddForceY(jumpForce, ForceMode2D.Impulse);
        //}

        if (Physics2D.OverlapCircle(groundCheckPosition.position, 0.5f, groundLayer))
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }


        if ((Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.Space)) && isGrounded)
        {
            _rigidBody2D.AddForceY(jumpForce, ForceMode2D.Impulse);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, 0.2f);
    }
}

