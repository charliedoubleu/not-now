using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel2 : MonoBehaviour
{
    void ChangeLevel2()
    {
        SceneManager.LoadScene(5);
    }

}