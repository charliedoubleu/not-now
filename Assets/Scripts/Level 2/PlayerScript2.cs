using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript2 : MonoBehaviour
{


    public float speed;
    private Rigidbody2D _rb;
    private float moveInputX;
    private float moveInputY;


   


    private SpriteRenderer _renderer;

    private Animator _anim;

    public ParticleSystem bubblesUp;
    public ParticleSystem bubblesDown;
    public ParticleSystem bubblesLeft;
    public ParticleSystem bubblesRight;



    private void Start()
    {
        _anim = GetComponent<Animator>();
        _rb = GetComponent<Rigidbody2D>();
        _renderer = GetComponent<SpriteRenderer>();
       

    }

    private void FixedUpdate()
    {
        moveInputX = Input.GetAxisRaw("Horizontal");
        moveInputY = Input.GetAxisRaw("Vertical");
        _rb.velocity = new Vector2(moveInputX * speed, moveInputY * speed);
        
    }

    private void Update()
    {

        
        if (moveInputX > 0)
        {
            transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y, -90);
            _renderer.flipX = false;
            _renderer.flipY = false;
            bubblesRight.Play();



        }
        else if (moveInputX < 0)
        {
            transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y, 90);
            _renderer.flipX = true;
            _renderer.flipY = false;
            bubblesLeft.Play();

        }

        if (moveInputY > 0)
        {
            transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y, 0);
            _renderer.flipY = false;
            _renderer.flipX = false;
            bubblesUp.Play();


        }
        else if (moveInputY < 0)
        {
            transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y, 0);
            
            _renderer.flipY = true;
            _renderer.flipX = false;
            bubblesDown.Play();

        }

    

        

        ////set animations
        //_anim.SetBool("isRunning", moveInput != 0);
        //_anim.SetBool("grounded", isGrounded);

    }

    //void SpawnBubbles()
    //{
    //    bubbles.Play();
    //}
}
