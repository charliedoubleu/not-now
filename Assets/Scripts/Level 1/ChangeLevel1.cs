using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeLevel1 : MonoBehaviour
{
    void NextLevel()
    {
        SceneManager.LoadScene(4);
    }
    
}
