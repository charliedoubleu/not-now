using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveClouds : MonoBehaviour
{
    public Transform destination;

    private void Update()
    {
        if(transform.position.x >= destination.position.x)
        {
            transform.Translate(Vector3.left * Time.deltaTime/2.25f);
        }
    }
}
