using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScores : MonoBehaviour
{
    private Text _score;
    private void Start()
    {
        _score = gameObject.GetComponent<Text>();
        _score.text = ScoringST.totalScore + "/26";
    }
}
