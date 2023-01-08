using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishPath : MonoBehaviour
{
    //array of destinations

    public GameObject[] destPoints;

    private float step = 0f;
    private float speed = 0f;
    public float accel = 0f;

    private int currentDest = 0;

    private SpriteRenderer _renderer;
    private bool flipState;


    private StressMeter2 playerScript;
    public ParticleSystem bubbleHit;
    public GameObject deathAnim;

    private float timeToWait = 3f;
    private float nextStep;

    private void Start()
    {
        nextStep = Time.time + timeToWait;
        _renderer = GetComponent<SpriteRenderer>();
        flipState = false;
        playerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<StressMeter2>();
    }
    //movetowards destination

    private void Update()
    {
        
        if (nextStep < Time.time)
        {
            if (currentDest != 4)
            {
                speed += accel * Time.deltaTime; // instant speed
                step = speed * Time.deltaTime; // calculate distance to move
                transform.position = Vector2.MoveTowards(transform.position, destPoints[currentDest].transform.position, step);


                if (Vector2.Distance(transform.position, destPoints[currentDest].transform.position) < 0.1f)
                {
                    flipState = !flipState;
                    _renderer.flipX = flipState;
                    transform.position = new Vector2(transform.position.x, transform.position.y + 4);
                    step = 0f;
                    speed = 0f;
                    currentDest++;



                }
            }

            if (deathAnim.activeInHierarchy)
            {
                currentDest = 0;
                step = 0f;
                speed = 0f;
                transform.position = new Vector2(20.0f, 4);
                _renderer.flipX = false;
                nextStep = Time.time + timeToWait;


            }



        }
    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            bubbleHit.Play();
            playerScript.AddStress(30.0f);
            

        }
    }

    //if reached dest then flip x, move y up by n, update destination



    //if curr dest is n then vel = 0 (for variety)
}
