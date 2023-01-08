using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightMove : MonoBehaviour
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
            if (transform.position.x <= destination.position.x)
            {
                transform.Translate(Vector3.right * Time.deltaTime / speed);
            }
        }
    }
}
