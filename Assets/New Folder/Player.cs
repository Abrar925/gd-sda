using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    private SpriteRenderer sr;
    bool gamrOver = false;

    private bool isDead;
    [HideInInspector] public bool playerUnlocked;
    [HideInInspector] public bool extraLife;


    [Header("Move info")]
    [SerializeField] private float moveSpeed;
    [SerializeField] private float jumpForce;
    [SerializeField] private float doubleJumpForce;

    private bool canDoubleJump;


    [Header("Slide info")]
    [SerializeField] private float slideSpeed;
    [SerializeField] private float slideTime;
    [SerializeField] private float slideCooldown;
    private float slideCooldownCounter;
    private float slidTimeCounter;
    private bool isSliding;

    [Header("Colission info")]
    [SerializeField] private float groundCheckDistance;
    [SerializeField] private float ceillingCheckDistanc;
    [SerializeField] private LayerMask whatIsGround;
    [SerializeField] private Transform wallCheck;
    [SerializeField] private Vector2 wallCheckSize;
    private bool isGrounded;
    private bool wallDetected;
    private bool ceillingDetected;
    [HideInInspector] public bool ledgDetected;




    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        {
            anim.SetFloat("xVelocity", rb.velocity.x);
            anim.SetFloat("yVelocity", rb.velocity.y);

            anim.SetBool("canDoubleJump", canDoubleJump);
            anim.SetBool("isGrounded", isGrounded);
            anim.SetBool("isSliding", isSliding);
        }

        slidTimeCounter -= Time.deltaTime;
        slideCooldownCounter -= Time.deltaTime;



        if (playerUnlocked)

            if (wallDetected)
                return;



        if (isSliding)
            rb.velocity = new Vector2(slideSpeed, rb.velocity.y);
        else
            rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
        {

            isGrounded = Physics2D.Raycast(transform.position, Vector2.down, groundCheckDistance, whatIsGround);
            ceillingDetected = Physics2D.Raycast(transform.position, Vector2.up, ceillingCheckDistanc, whatIsGround);
            wallDetected = Physics2D.BoxCast(wallCheck.position, wallCheckSize, 0, Vector2.zero, 0, whatIsGround);


        }

        if (isGrounded)
            canDoubleJump = true;


        {
            if (Input.GetButtonDown("Fire2"))
                playerUnlocked = true;


            if (Input.GetButtonDown("Fire1"))
                JumpButton(); 


            if (Input.GetKeyDown(KeyCode.Minus))
                SlideButton();


        }

        CheckForSlide();

    }

    private void SlideButton()
    {
        if (rb.velocity.x != 0 && slideCooldownCounter < 0)
        {
            isSliding = true;
            slidTimeCounter = slideTime;
            slideCooldownCounter = slideCooldown;
        }
    }

    private void CheckForSlide()
    {
        if (slidTimeCounter < 0 && !ceillingDetected)
            isSliding = false;
    }

    private void JumpButton()
    {
        if (isSliding)
            return;

        if (isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
        else if (canDoubleJump)
        {
            canDoubleJump = false;
            rb.velocity = new Vector2(rb.velocity.x, doubleJumpForce);
        }
    }

    private void OnDrawGizmos()

    {
        Gizmos.DrawLine(transform.position, new Vector2(transform.position.x, transform.position.y - groundCheckDistance));
        Gizmos.DrawLine(transform.position, new Vector2(transform.position.x, transform.position.y + ceillingCheckDistanc));
        Gizmos.DrawWireCube(wallCheck.position, wallCheckSize);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Obstacles")
        {
            Destroy(collision.gameObject);
            anim.Play("Death99");
            GameManager.instance.GameOver();
            gamrOver = true;
            //audioManager.PlaySFX(audioManager.death);
        }
    }
}
