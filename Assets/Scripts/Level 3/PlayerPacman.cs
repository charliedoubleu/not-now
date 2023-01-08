using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPacman : MonoBehaviour
{

    public float speed;
    private Rigidbody2D _rb;
    private float moveInputX;
    private float moveInputY;





    private SpriteRenderer _renderer;

    private Animator _anim;


    private float timeToWait = 4f;
    private float nextStep;


    private void Start()
    {
        _anim = GetComponent<Animator>();
        _rb = GetComponent<Rigidbody2D>();
        _renderer = GetComponent<SpriteRenderer>();
        nextStep = Time.time + timeToWait;


    }

    private void FixedUpdate()
    {
        if (nextStep < Time.time)
        {
            moveInputX = Input.GetAxisRaw("Horizontal");
            moveInputY = Input.GetAxisRaw("Vertical");
            _rb.velocity = new Vector2(moveInputX * speed, moveInputY * speed);
        }

    }

    private void Update()
    {

        ////set animations
        _anim.SetBool("isMoving", moveInputX != 0 || moveInputY != 0);


        if (moveInputX > 0)
        {
            
            _renderer.flipX = true;
            



        }
        else if (moveInputX < 0)
        {
            
            _renderer.flipX = false;
            


        }








       

    }


}
