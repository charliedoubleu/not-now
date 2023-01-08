using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    //private int letters;
    [SerializeField] private Text scoreText;

    public GameObject pickupSound;

    private void Awake()
    {
        //letters = ScoringST.totalScore;
        scoreText.text = ScoringST.totalScore + "/26";
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Letter"))
        {
            Destroy(collision.gameObject);
            Instantiate(pickupSound, collision.transform.position, Quaternion.identity);
            ///letters++;
            ScoringST.totalScore++;
            scoreText.text = ScoringST.totalScore + "/26";
            
        }

    }
}
