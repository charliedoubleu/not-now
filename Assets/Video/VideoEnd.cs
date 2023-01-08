using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;


public class VideoEnd : MonoBehaviour
{
    private VideoPlayer VideoPlayer;

    
    void Start()
    {
        VideoPlayer = GetComponent<VideoPlayer>();
        VideoPlayer.loopPointReached += LoadScene;
    }

    void LoadScene(VideoPlayer vp)
    {
        SceneManager.LoadScene(1);
    }

    

}