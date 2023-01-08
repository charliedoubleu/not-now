using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float jumpForce;

    public float speed;
    private Rigidbody2D _rb;
    private float moveInput;

    public Transform groundPos;
    private bool isGrounded;
    public float checkRadius;

    public LayerMask whatIsGround;

    private float jumpTimeCounter;
    public float jumpTime;
    private bool isJumping;
    //private bool doubleJump;

    private SpriteRenderer _renderer;

    private Animator _anim;

    public ParticleSystem grass;

    private void Start()
    {
        _anim = GetComponent<Animator>();
        _rb = GetComponent<Rigidbody2D>();
        _renderer = GetComponent<SpriteRenderer>();

    }

    private void FixedUpdate()
    {
        moveInput = Input.GetAxisRaw("Horizontal");
        _rb.velocity = new Vector2(moveInput * speed, _rb.velocity.y);
    }

    private void Update()
    {
        

        if(moveInput > 0)
        {
            _renderer.flipX = false;
        }else if (moveInput < 0)
        {
            _renderer.flipX = true;
        }

     

        isGrounded = Physics2D.OverlapCircle(groundPos.position, checkRadius, whatIsGround);

        //set animations
        _anim.SetBool("isRunning", moveInput != 0);
        _anim.SetBool("grounded", isGrounded);


        if (isGrounded == true && Input.GetKeyDown(KeyCode.Space))
        {
            
            isJumping = true;
            jumpTimeCounter = jumpTime;
            _rb.velocity = Vector2.up * jumpForce;
        }

        if (Input.GetKey(KeyCode.Space) && isJumping == true)
        {
            if(jumpTimeCounter > 0)
            {
                
                _rb.velocity = Vector2.up * jumpForce;
                _anim.SetTrigger("jump");
                jumpTimeCounter -= Time.deltaTime;
            }
            else
            {
                isJumping = false;
            }

        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            isJumping = false;
        }

        if(isGrounded && moveInput != 0)
        {
            grass.Play();
        }

    }

    void SpawnGrass()
    {
        grass.Play();
    }
}
