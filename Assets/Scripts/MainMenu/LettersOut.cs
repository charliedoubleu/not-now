using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LettersOut : MonoBehaviour
{
    public void endAnim()
    {
        SceneManager.LoadScene(2);
    }
}
