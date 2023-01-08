using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevel : MonoBehaviour
{
    public GameObject endTransition;

    public GameObject waterSound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

            endTransition.SetActive(true);
            Instantiate(waterSound, transform.position, Quaternion.identity);
        }
    }


}
