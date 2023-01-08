using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlowWind : MonoBehaviour
{
    public GameObject windSound;
    private float timeToWait = 4f;
    private float nextStep;
    private int count = 0;

    [SerializeField]
    private float speed;

    private void Start()
    {
        nextStep = Time.time + timeToWait;
    }

    private void Update()
    {
        if (nextStep < Time.time)
        {
            if (count < 1)
            {
                Instantiate(windSound, transform.position, Quaternion.identity);
                count++;
            }

            transform.Translate(Vector3.left * Time.deltaTime / speed);
        }
    }

}
