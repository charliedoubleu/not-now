using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightMove2 : MonoBehaviour
{
    public Transform destination;

    [SerializeField]
    private float speed;

    private float timeToWait = 3f;
    private float nextStep;

    private void Start()
    {
        nextStep = Time.time + timeToWait;
    }


    private void Update()
    {
        if (nextStep < Time.time)
        {
            if (transform.position.y <= destination.position.y)
            {
                transform.Translate(Vector3.up * Time.deltaTime / speed);
            }

            if (transform.position.y == 0)
            {
                nextStep = Time.time + timeToWait;
            }
        }


    }
}
