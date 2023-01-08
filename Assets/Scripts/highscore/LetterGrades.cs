using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LetterGrades : MonoBehaviour
{
    private Text _grade;
    private float score;
    private void Start()
    {
        _grade = gameObject.GetComponent<Text>();
        score = ScoringST.totalScore;
        
        
       
    

        if(score/26 >= 0.90)
        {
            _grade.text = "A";
        }else if(score/26 <= 0.89 && score/26 >= 0.80)
        {
            _grade.text = "B";
        }
        else if (score/26 <= 0.79 && score/26 >= 0.70)
        {
            _grade.text = "C";
        }
        else if (score/26 <= 0.69 && score/26 >= 0.60)
        {
            _grade.text = "D";
        }
        else
        {
            _grade.text = "F";
        }
    }
}
