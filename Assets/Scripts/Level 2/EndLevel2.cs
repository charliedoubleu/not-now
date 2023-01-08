using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevel2 : MonoBehaviour
{
    public GameObject endTransition;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            endTransition.SetActive(true);
        }
    }
}
