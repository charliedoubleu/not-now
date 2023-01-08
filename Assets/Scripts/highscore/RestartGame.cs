using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    public void BackToMenu()
    {
        ScoringST.totalScore = 0;
        SceneManager.LoadScene(1);
    }
}
